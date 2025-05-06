
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using Cysharp.Threading.Tasks;
using StationeersMods.Interface;
using StationeersMods.Shared;
using UnityEngine;

namespace StationeersLaunchPad
{
  public class LoadedMod
  {
    private object _lock = new();

    public ModInfo Info;

    public Logger Logger;

    public List<Assembly> Assemblies = new();
    public List<GameObject> Prefabs = new();
    public List<ExportSettings> Exports = new();
    public ContentHandler ContentHandler;

    public List<Type> SMEntryTypes = new();
    public List<Type> BepinexEntryTypes = new();
    public List<GameObject> EntryPrefabs = new();

    public List<ConfigFile> ConfigFiles = new();

    public bool LoadFinished = false;
    public bool LoadFailed = false;

    public LoadedMod(ModInfo info)
    {
      this.Logger = Logger.Global.WithPrefix($"[{info.DisplayName}]");
      this.Info = info;
      var resource = new DummyResource(info.Path);
      this.ContentHandler = new(resource, new List<IResource>().AsReadOnly(), this.Prefabs.AsReadOnly());
    }

    public async UniTask LoadAssembliesSerial()
    {
      foreach (var assemblyInfo in this.Info.Assemblies)
        this.Assemblies.Add(await this.LoadAssembly(assemblyInfo));
    }
    public async UniTask LoadAssembliesParallel()
    {
      var assemblies = await UniTask.WhenAll(
        this.Info.Assemblies.Select(assemblyInfo => this.LoadAssembly(assemblyInfo))
      );
      this.Assemblies.AddRange(assemblies);
    }

    public async UniTask LoadAssetsSerial()
    {
      foreach (var path in this.Info.AssetBundles)
      {
        await this.LoadAssetsSingle(path);
      }
    }
    public async UniTask LoadAssetsParallel()
    {
      await UniTask.WhenAll(this.Info.AssetBundles.Select(path => this.LoadAssetsSingle(path)));
    }

    public UniTask FindEntrypoints()
    {
      return UniTask.RunOnThreadPool(() =>
      {
        this.Logger.Log("Finding Entrypoints");

        this.SMEntryTypes.AddRange(ModLoader.FindExplicitStationeersModsEntrypoints(this.Assemblies));
        foreach (var type in ModLoader.FindExportSettingsClassEntrypoints(this.Assemblies, this.Exports))
        {
          if (!this.SMEntryTypes.Contains(type))
            this.SMEntryTypes.Add(type);
        }
        foreach (var type in this.SMEntryTypes)
          this.Logger.Log($"- StationeersMods {type.FullName}");
        foreach (var exportSettings in this.Exports)
        {
          var prefab = exportSettings._startupPrefab;
          if (prefab != null)
          {
            this.EntryPrefabs.Add(prefab);
            this.Logger.Log($"- prefab {prefab.name}");
          }
        }
        this.BepinexEntryTypes.AddRange(ModLoader.FindBepinexEntrypoints(this.Assemblies));
        foreach (var type in this.BepinexEntryTypes)
          this.Logger.Log($"- Bepinex {type.FullName}");
      });
    }

    public UniTask LoadEntrypoints()
    {
      return UniTask.RunOnThreadPool(() =>
      {
        this.Logger.Log("Loading Entrypoints");

        // StationeersMods tagged ModBehaviour/StartupClass/StartupPrefab
        var modBehaviours = new List<ModBehaviour>();
        if (this.SMEntryTypes.Count > 0)
        {
          var gameObj = new GameObject();
          GameObject.DontDestroyOnLoad(gameObj);
          foreach (var type in this.SMEntryTypes)
            gameObj.AddComponent(type);
          modBehaviours.AddRange(gameObj.GetComponents<ModBehaviour>());
        }
        foreach (var prefab in this.EntryPrefabs)
        {
          var gameObj = GameObject.Instantiate(prefab);
          GameObject.DontDestroyOnLoad(gameObj);
          modBehaviours.AddRange(gameObj.GetComponents<ModBehaviour>());
        }
        foreach (var modBehaviour in modBehaviours)
        {
          modBehaviour.contentHandler = this.ContentHandler;
          modBehaviour.OnLoaded(this.ContentHandler);
          this.ConfigFiles.Add(modBehaviour.Config);
        }

        foreach (var type in this.BepinexEntryTypes)
        {
          var gameObj = new GameObject();
          GameObject.DontDestroyOnLoad(gameObj);
          var component = gameObj.AddComponent(type);
          if (component is BaseUnityPlugin plugin)
            this.ConfigFiles.Add(plugin.Config);
        }

        this.Logger.Log("Done");

        this.LoadFinished = true;
      });
    }

    private async UniTask<Assembly> LoadAssembly(AssemblyInfo assemblyInfo)
    {
      this.Logger.Log($"Loading Assembly {assemblyInfo.Name}");
      var assembly = await ModLoader.LoadAssembly(assemblyInfo.Path);
      ModLoader.RegisterAssembly(assembly, this);
      return assembly;
    }

    private async UniTask LoadAssetsSingle(string path)
    {
      var bundle = await this.LoadAssetBundle(path);
      var prefabs = await this.LoadAssetBundleGameObjects(path, bundle);
      lock (this._lock) this.Prefabs.AddRange(prefabs);
      var exportSettings = await this.LoadAssetBundleExportSettings(path, bundle);
      if (exportSettings != null)
        lock (this._lock) this.Exports.Add(exportSettings);
    }

    private UniTask<AssetBundle> LoadAssetBundle(string path)
    {
      var name = Path.GetFileName(path);
      this.Logger.Log($"Loading AssetBundle {name}");
      return ModLoader.LoadAssetBundle(path);
    }

    private async UniTask<List<GameObject>> LoadAssetBundleGameObjects(string path, AssetBundle bundle)
    {
      var name = Path.GetFileName(path);
      this.Logger.Log($"Loading AssetBundle {name} Prefabs");
      var assets = await ModLoader.LoadAllBundleAssets(bundle);
      foreach (var asset in assets)
        this.Logger.Log($"- {asset.name}");
      return assets;
    }

    private UniTask<ExportSettings> LoadAssetBundleExportSettings(string path, AssetBundle bundle)
    {
      var name = Path.GetFileName(path);
      this.Logger.Log($"Loading AssetBundle {name} ExportSettings");
      return ModLoader.LoadBundleExportSettings(bundle);
    }
  }
}