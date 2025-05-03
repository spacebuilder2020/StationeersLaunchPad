
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Cysharp.Threading.Tasks;
using Assets.Scripts;
using Assets.Scripts.Networking.Transports;
using Assets.Scripts.Serialization;
using Mono.Cecil;
using Steamworks;
using Steamworks.Ugc;

namespace SMPreloader
{
  public enum LoadState
  {
    Initializing,
    Configuring,
    ModsLoading,
    ModsLoaded,
    GameRunning
  }
  public static class SMConfig
  {
    public static SplashBehaviour SplashBehaviour;
    public static List<ModInfo> Mods = new();
    public static HashSet<string> GameAssemblies = new();
    public static LoadState LoadState = LoadState.Initializing;
    public static bool AutoLoad = true;
    public static Stopwatch AutoStopwatch = new();

    public const double AutoWaitTime = 3;

    public static async UniTaskVoid Run()
    {
      await Load();

      while (LoadState < LoadState.Configuring)
        await UniTask.Yield();

      AutoStopwatch.Restart();

      while (LoadState == LoadState.Configuring && (!AutoLoad || AutoStopwatch.Elapsed.TotalSeconds < AutoWaitTime))
        await UniTask.Yield();

      if (LoadState == LoadState.Configuring)
        LoadState = LoadState.ModsLoading;

      if (LoadState == LoadState.ModsLoading)
        await LoadMods();

      AutoStopwatch.Restart();

      while (LoadState == LoadState.ModsLoaded && (!AutoLoad || AutoStopwatch.Elapsed.TotalSeconds < AutoWaitTime))
        await UniTask.Yield();

      StartGame();
    }

    private static async UniTask Load()
    {
      try
      {
        LoadState = LoadState.Initializing;

        await UniTask.Run(() => Initialize());

        Logger.Global.Log("Listing Local Mods");
        await UniTask.Run(() => LoadLocalItems());

        Logger.Global.Log("Listing Workshop Mods");
        await LoadWorkshopItems();

        Logger.Global.Log("Loading Mod Order");
        await UniTask.Run(() => LoadConfig());

        Logger.Global.Log("Listing Game Assemblies");
        await UniTask.Run(() => LoadGameAssemblies());

        Logger.Global.Log("Loading Details");
        await LoadDetails();

        Logger.Global.Log("Mod Config Initialized");

        LoadState = LoadState.Configuring;
      }
      catch (Exception ex)
      {
        Logger.Global.LogError("Error occurred during initialization. Mods will not be loaded");
        Logger.Global.LogException(ex);
        Mods = new();
        LoadState = LoadState.ModsLoaded;
        AutoLoad = false;
      }
    }

    private static void Initialize()
    {
      if (string.IsNullOrEmpty(Settings.CurrentData.SavePath))
        Settings.CurrentData.SavePath = StationSaveUtils.DefaultPath;
      if (!SteamClient.IsValid)
      {
        try
        {
          SteamClient.Init(544550u);
        }
        catch (Exception ex)
        {
          Logger.Global.LogError($"failed to initialize steam: {ex.Message}");
          Logger.Global.LogError("workshop mods will not be loaded");
          AutoLoad = false;
        }
      }
      Mods.Add(new ModInfo { Source = ModSource.Core });
    }

    private static void LoadConfig()
    {
      var path = WorkshopMenu.ConfigPath;
      var config = new ModConfig();
      if (File.Exists(path))
        config = XmlSerialization.Deserialize<ModConfig>(path);
      config.CreateCoreMod();

      var modsByPath = new Dictionary<string, ModInfo>();
      foreach (var mod in Mods)
      {
        modsByPath[mod.Path] = mod;
      }

      var newMods = new List<ModInfo>();
      foreach (var modcfg in config.Mods)
      {
        var modPath = (string)modcfg.DirectoryPath;
        if (modsByPath.TryGetValue(modPath, out var mod))
        {
          mod.Enabled = modcfg.Enabled;
          newMods.Add(mod);
          modsByPath.Remove(modPath);
        }
        else if (modcfg.Enabled)
        {
          Logger.Global.LogWarning($"enabled mod not found at {modPath}");
        }
      }
      foreach (var mod in modsByPath.Values)
      {
        Logger.Global.Log($"new mod added at {mod.Path}");
        newMods.Add(mod);
        mod.Enabled = true;
      }
      Mods = newMods;
    }

    private static void LoadLocalItems()
    {
      var type = SteamTransport.WorkshopType.Mod;
      var localDir = type.GetLocalDirInfo();
      var fileName = type.GetLocalFileName();

      foreach (var dir in localDir.GetDirectories("*", SearchOption.AllDirectories))
      {
        foreach (var file in dir.GetFiles(fileName))
        {
          Mods.Add(new ModInfo
          {
            Source = ModSource.Local,
            Wrapped = SteamTransport.ItemWrapper.WrapLocalItem(file, type),
          });
        }
      }
    }

    private static async UniTask LoadWorkshopItems()
    {
      for (var page = 1; ; page++)
      {
        var query = Query.Items.WithTag("Mod");
        var result = await query.AllowCachedResponse(0).WhereUserSubscribed().GetPageAsync(page);

        if (!result.HasValue || result.Value.ResultCount == 0)
          break;

        foreach (var item in result.Value.Entries)
        {
          Mods.Add(new ModInfo
          {
            Source = ModSource.Workshop,
            Wrapped = SteamTransport.ItemWrapper.WrapWorkshopItem(item, "About\\About.xml"),
            WorkshopItem = item,
          });
        }
      }
    }

    private static void LoadGameAssemblies()
    {
      foreach (var file in Directory.EnumerateFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll", SearchOption.AllDirectories))
      {
        try
        {
          using var def = AssemblyDefinition.ReadAssembly(file);
          GameAssemblies.Add(def.Name.Name);
        }
        catch (BadImageFormatException)
        {
          // silently ignore
        }
        catch (Exception ex)
        {
          Logger.Global.LogError($"error reading game assembly {file}: {ex.Message}");
        }
      }
    }

    private static async UniTask LoadDetails()
    {
      await UniTask.WhenAll(Mods.Select(mod => UniTask.Run(() => LoadModDetails(mod))));
    }

    private static void LoadModDetails(ModInfo mod)
    {
      if (mod.Source == ModSource.Core)
        return;

      mod.About = XmlSerialization.Deserialize<ModAbout>(mod.Wrapped.FilePathFullName, "ModMetadata");

      foreach (var file in Directory.GetFiles(mod.Wrapped.DirectoryPath, "*.dll", SearchOption.AllDirectories))
      {
        var info = new AssemblyInfo { Path = file, Dependencies = new() };

        using (var def = AssemblyDefinition.ReadAssembly(file))
        {
          info.Name = def.Name.Name;
          foreach (var module in def.Modules)
            foreach (var mref in module.AssemblyReferences)
              if (!GameAssemblies.Contains(mref.Name))
                info.Dependencies.Add(mref.Name);
        }
        mod.Assemblies.Add(info);
      }

      foreach (var file in Directory.GetFiles(mod.Wrapped.DirectoryPath, "*.assets", SearchOption.AllDirectories))
      {
        mod.AssetBundles.Add(file);
      }
    }

    public static void SaveConfig()
    {
      var config = new ModConfig();
      foreach (var mod in Mods)
      {
        config.Mods.Add(mod.Source switch
        {
          ModSource.Core => new CoreModData(),
          ModSource.Local => new LocalModData(mod.Path, mod.Enabled),
          ModSource.Workshop => new WorkshopModData(mod.Wrapped, mod.Enabled),
          _ => throw new Exception($"invalid mod source: {mod.Source}"),
        });
      }

      config.SaveXml(WorkshopMenu.ConfigPath);
    }

    private async static UniTask LoadMods()
    {
      LoadState = LoadState.ModsLoading;

      var strategy = new LinearLoadStrategy();
      await strategy.Load();

      Logger.Global.Log("Mods Loaded");
      LoadState = LoadState.ModsLoaded;
    }

    private static void StartGame()
    {
      LoadState = LoadState.GameRunning;
      var co = (IEnumerator)typeof(SplashBehaviour).GetMethod("AwakeCoroutine", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(SplashBehaviour, new object[] { });
      SplashBehaviour.StartCoroutine(co);
      SMPreloaderGUI.IsActive = false;
    }
  }
}