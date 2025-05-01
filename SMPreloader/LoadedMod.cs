
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using StationeersMods.Interface;
using StationeersMods.Shared;
using UnityEngine;

namespace SMPreloader
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

    public bool LoadFinished = false;

    public LoadedMod(ModInfo info)
    {
      this.Logger = Logger.GlobalPrefixed($"[{info.DisplayName}]");
      this.Info = info;
      this.ContentHandler = new(null, new List<IResource>().AsReadOnly(), this.Prefabs.AsReadOnly());
    }

    public async Task LoadAssembliesSerial()
    {
      foreach (var assemblyInfo in this.Info.Assemblies)
        this.Assemblies.Add(await this.LoadAssembly(assemblyInfo));
    }
    public async Task LoadAssembliesParallel()
    {
      var assemblies = await Task.WhenAll(
        this.Info.Assemblies.Select(assemblyInfo => this.LoadAssembly(assemblyInfo))
      );
      this.Assemblies.AddRange(assemblies);
    }

    public async Task LoadAssetsSerial()
    {
      foreach (var path in this.Info.AssetBundles)
      {
        await this.LoadAssetsSingle(path);
      }
    }
    public async Task LoadAssetsParallel()
    {
      await Task.WhenAll(this.Info.AssetBundles.Select(path => this.LoadAssetsSingle(path)));
    }

    public Task FindEntrypoints()
    {
      return Task.Run(() =>
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

    public Task LoadEntrypoints()
    {
      return Task.Run(() =>
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
        }

        foreach (var type in this.BepinexEntryTypes)
        {
          var gameObj = new GameObject();
          GameObject.DontDestroyOnLoad(gameObj);
          gameObj.AddComponent(type);
        }

        this.Logger.Log("Done");

        this.LoadFinished = true;
      });
    }

    private async Task<Assembly> LoadAssembly(AssemblyInfo assemblyInfo)
    {
      this.Logger.Log($"Loading Assembly {assemblyInfo.Name}");
      var assembly = await ModLoader.LoadAssembly(assemblyInfo.Path);
      ModLoader.RegisterAssembly(assembly, this);
      return assembly;
    }

    private async Task LoadAssetsSingle(string path)
    {
      var bundle = await this.LoadAssetBundle(path);
      var prefabs = await this.LoadAssetBundleGameObjects(path, bundle);
      lock (this._lock) this.Prefabs.AddRange(prefabs);
      var exportSettings = await this.LoadAssetBundleExportSettings(path, bundle);
      if (exportSettings != null)
        lock (this._lock) this.Exports.Add(exportSettings);
    }

    private Task<AssetBundle> LoadAssetBundle(string path)
    {
      var name = Path.GetFileName(path);
      this.Logger.Log($"Loading AssetBundle {name}");
      return ModLoader.LoadAssetBundle(path);
    }

    private async Task<List<GameObject>> LoadAssetBundleGameObjects(string path, AssetBundle bundle)
    {
      var name = Path.GetFileName(path);
      this.Logger.Log($"Loading AssetBundle {name} Prefabs");
      var assets = await ModLoader.LoadAllBundleAssets(bundle);
      foreach (var asset in assets)
        this.Logger.Log($"- {asset.name}");
      return assets;
    }

    private Task<ExportSettings> LoadAssetBundleExportSettings(string path, AssetBundle bundle)
    {
      var name = Path.GetFileName(path);
      this.Logger.Log($"Loading AssetBundle {name} ExportSettings");
      return ModLoader.LoadBundleExportSettings(bundle);
    }
  }
}