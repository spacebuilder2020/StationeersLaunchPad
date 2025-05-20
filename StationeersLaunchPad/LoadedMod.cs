
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
    public List<(Type, MethodInfo)> DefaultEntryTypes = new();
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

    public void ResolveAssemblies()
    {
      foreach (var assembly in this.Assemblies)
        assembly.GetTypes();
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
        // StationeersMods would take any ModBehaviour it found as an entrypoint when there were no ExportSettings
        // We'll do the same to ensure any mods relying on this still work
        if (this.Exports.Count == 0)
        {
          foreach (var type in ModLoader.FindAnyStationeersModsEntrypoints(this.Assemblies))
          {
            if (!this.SMEntryTypes.Contains(type))
              this.SMEntryTypes.Add(type);
          }
        }
        foreach (var exportSettings in this.Exports)
        {
          var prefab = exportSettings._startupPrefab;
          if (prefab != null)
            this.EntryPrefabs.Add(prefab);
        }
        this.BepinexEntryTypes.AddRange(ModLoader.FindBepinexEntrypoints(this.Assemblies));

        this.DefaultEntryTypes.AddRange(ModLoader.FindDefaultEntrypoints(this.Assemblies));
      });
    }

    public void PrintEntrypoints()
    {
      // getting prefab names fails on a thread in the debug player, so just print all the entrypoints after we finish
      foreach (var type in this.SMEntryTypes)
        this.Logger.Log($"- StationeersMods {type.FullName}");
      foreach (var prefab in this.EntryPrefabs)
        this.Logger.Log($"- prefab {prefab.name}");
      foreach (var type in this.BepinexEntryTypes)
        this.Logger.Log($"- Bepinex {type.FullName}");
      foreach (var (type, _) in this.DefaultEntryTypes)
        this.Logger.Log($"- Default {type.FullName}");
    }

    public void LoadEntrypoints()
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
        if (modBehaviour.Config != null)
        {
          modBehaviour.Config.SettingChanged += (_, _) => this.DirtyConfig();
          this.ConfigFiles.Add(modBehaviour.Config);
        }
      }

      foreach (var type in this.BepinexEntryTypes)
      {
        var gameObj = new GameObject();
        GameObject.DontDestroyOnLoad(gameObj);
        var component = gameObj.AddComponent(type);
        if (component is BaseUnityPlugin plugin && plugin.Config != null)
        {
          plugin.Config.SettingChanged += (_, _) => this.DirtyConfig();
          this.ConfigFiles.Add(plugin.Config);
        }
      }

      foreach (var (type, method) in this.DefaultEntryTypes)
      {
        var gameObj = new GameObject();
        GameObject.DontDestroyOnLoad(gameObj);
        var component = gameObj.AddComponent(type);
        method.Invoke(component, new object[] { this.Prefabs });
      }

      this.ConfigFiles.Sort((a, b) => a.ConfigFilePath.CompareTo(b.ConfigFilePath));

      this.Logger.Log("Done");

      this.LoadFinished = true;
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

    private bool _configDirty = true;
    private void DirtyConfig() { this._configDirty = true; }

    private List<SortedConfigFile> _cachedSortedConfigs = new();
    private int _cachedTotalConfigs = 0;

    public List<SortedConfigFile> GetSortedConfigs()
    {
      var totalCount = 0;
      foreach (var config in this.ConfigFiles)
        totalCount += config.Count;
      if (this._configDirty || totalCount != this._cachedTotalConfigs)
      {
        var sortedConfigs = new List<SortedConfigFile>();
        foreach (var config in this.ConfigFiles)
          if (config.Count > 0)
            sortedConfigs.Add(new SortedConfigFile(config));

        this._cachedTotalConfigs = totalCount;
        this._cachedSortedConfigs = sortedConfigs;
        this._configDirty = false;
      }
      return this._cachedSortedConfigs;
    }
  }

  public class SortedConfigFile
  {
    public readonly ConfigFile ConfigFile;
    public readonly string FileName;
    public readonly List<SortedConfigCategory> Categories;

    public SortedConfigFile(ConfigFile configFile)
    {
      this.ConfigFile = configFile;
      this.FileName = Path.GetFileName(configFile.ConfigFilePath);
      var categories = new List<SortedConfigCategory>();
      foreach (var group in configFile.Select(entry => entry.Value).GroupBy(entry => entry.Definition.Section))
      {
        categories.Add(new SortedConfigCategory(
          configFile,
          group.Key,
          group.OrderBy(entry => entry.Definition.Key).ToList()
        ));
      }
      categories.Sort((a, b) => a.Category.CompareTo(b.Category));
      this.Categories = categories;
    }
  }

  public class SortedConfigCategory
  {
    public readonly ConfigFile ConfigFile;
    public readonly string Category;
    public readonly List<ConfigEntryBase> Entries;

    public SortedConfigCategory(ConfigFile configFile, string category, List<ConfigEntryBase> entries)
    {
      this.ConfigFile = configFile;
      this.Category = category;
      this.Entries = entries;
    }
  }
}