
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Assets.Scripts;
using Assets.Scripts.Networking.Transports;
using Assets.Scripts.Serialization;
using Mono.Cecil;
using Steamworks;
using Steamworks.Ugc;
using UnityEngine;

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

    public static async void Load()
    {
      LoadState = LoadState.Initializing;

      await Task.Run(() =>
      {
        if (string.IsNullOrEmpty(Settings.CurrentData.SavePath))
          Settings.CurrentData.SavePath = StationSaveUtils.DefaultPath;
        if (!SteamClient.IsValid)
          SteamClient.Init(544550u);
        Mods.Add(new ModInfo { Source = ModSource.Core });
      });


      Logger.GlobalLog("Listing Local Mods");
      await Task.Run(() => LoadLocalItems());

      Logger.GlobalLog("Listing Workshop Mods");
      await LoadWorkshopItems();

      Logger.GlobalLog("Loading Mod Order");
      await Task.Run(() => LoadConfig());

      Logger.GlobalLog("Listing Game Assemblies");
      await Task.Run(() => LoadGameAssemblies());

      Logger.GlobalLog("Loading Details");
      await LoadDetails();

      LoadState = LoadState.Configuring;
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
          Logger.GlobalLog($"enabled mod not found at {modPath}");
        }
      }
      foreach (var mod in modsByPath.Values)
      {
        Logger.GlobalLog($"new mod added at {mod.Path}");
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

    private static async Task LoadWorkshopItems()
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
          Logger.GlobalLog($"error reading game assembly {file}: {ex.Message}");
        }
      }
    }

    private static async Task LoadDetails()
    {
      await Task.WhenAll(Mods.Select(mod => Task.Run(() => LoadModDetails(mod))));
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

    public async static void LoadMods()
    {
      LoadState = LoadState.ModsLoading;

      var strategy = new LinearLoadStrategy();
      await strategy.Load();

      LoadState = LoadState.ModsLoaded;
    }

    public static void StartGame()
    {
      LoadState = LoadState.GameRunning;
      var co = (IEnumerator)typeof(SplashBehaviour).GetMethod("AwakeCoroutine", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(SplashBehaviour, new object[] { });
      SplashBehaviour.StartCoroutine(co);
      SMPreloaderGUI.IsActive = false;
    }
  }
}