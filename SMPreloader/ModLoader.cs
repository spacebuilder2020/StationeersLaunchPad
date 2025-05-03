using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Cysharp.Threading.Tasks;
using BepInEx;
using StationeersMods.Interface;
using StationeersMods.Shared;
using UnityEngine;

namespace SMPreloader
{
  public static class ModLoader
  {
    public static readonly List<LoadedMod> LoadedMods = new();

    private static object AssembliesLock = new();
    private static readonly Dictionary<Assembly, LoadedMod> AssemblyToMod = new();

    public static void RegisterAssembly(Assembly assembly, LoadedMod mod)
    {
      lock (AssembliesLock)
      {
        AssemblyToMod[assembly] = mod;
      }
    }

    public static bool TryGetExecutingMod(out LoadedMod mod)
    {
      return TryGetStackTraceMod(new StackTrace(3), out mod);
    }

    public static bool TryGetStackTraceMod(StackTrace st, out LoadedMod mod)
    {
      lock (AssembliesLock)
      {
        for (var i = 0; i < st.FrameCount; i++)
        {
          var frame = st.GetFrame(i);
          if (AssemblyToMod.TryGetValue(frame.GetMethod().DeclaringType.Assembly, out mod))
            return true;
        }
      }
      mod = null;
      return false;
    }

    public static UniTask<Assembly> LoadAssembly(string path)
    {
      return UniTask.RunOnThreadPool(() => Assembly.LoadFrom(path));
    }

    public static async UniTask WaitFor(AsyncOperation op)
    {
      while (!op.isDone)
        await UniTask.Yield();
    }

    public static async UniTask<AssetBundle> LoadAssetBundle(string path)
    {
      var request = AssetBundle.LoadFromFileAsync(path);
      await WaitFor(request);
      return request.assetBundle;
    }

    public static async UniTask<List<GameObject>> LoadAllBundleAssets(AssetBundle bundle)
    {
      var request = bundle.LoadAllAssetsAsync<GameObject>();
      await WaitFor(request);
      return request.allAssets.Select(obj => (GameObject)obj).ToList();
    }

    public static async UniTask<ExportSettings> LoadBundleExportSettings(AssetBundle bundle)
    {
      var request = bundle.LoadAssetAsync<ExportSettings>("ExportSettings");
      await WaitFor(request);
      return (ExportSettings)request.asset;
    }

    public static List<Type> FindExplicitStationeersModsEntrypoints(List<Assembly> assemblies)
    {
      var result = new List<Type>();
      foreach (var assembly in assemblies)
      {
        foreach (var type in assembly.GetTypes())
        {
          var attr = type.GetCustomAttribute<StationeersMod>();
          if (attr != null && typeof(ModBehaviour).IsAssignableFrom(type))
            result.Add(type);
        }
      }
      return result;
    }

    public static List<Type> FindExportSettingsClassEntrypoints(List<Assembly> assemblies, List<ExportSettings> exports)
    {
      var result = new List<Type>();
      foreach (var exportSettings in exports)
      {
        var startupClass = exportSettings._startupClass;
        if (string.IsNullOrEmpty(startupClass))
          continue;
        foreach (var assembly in assemblies)
        {
          var type = assembly.GetType(startupClass);
          if (type != null)
            result.Add(type);
        }
      }
      return result;
    }

    public static List<Type> FindBepinexEntrypoints(List<Assembly> assemblies)
    {
      var result = new List<Type>();
      foreach (var assembly in assemblies)
      {
        foreach (var type in assembly.GetTypes())
        {
          if (typeof(BaseUnityPlugin).IsAssignableFrom(type) && !typeof(ModBehaviour).IsAssignableFrom(type))
            result.Add(type);
        }
      }
      return result;
    }
  }

  public abstract class LoadStrategy
  {
    public abstract UniTask Load();
  }

  public class LinearLoadStrategy : LoadStrategy
  {
    public override async UniTask Load()
    {
      foreach (var modInfo in SMConfig.Mods)
      {
        if (!modInfo.Enabled) continue;
        if (modInfo.Source == ModSource.Core) continue;

        var mod = new LoadedMod(modInfo);
        modInfo.Loaded = mod;
        ModLoader.LoadedMods.Add(mod);

        try
        {
          await mod.LoadAssembliesSerial();
          await mod.LoadAssetsSerial();
          await mod.FindEntrypoints();
          await mod.LoadEntrypoints();
        }
        catch (Exception ex)
        {
          mod.Logger.LogException(ex);
          mod.LoadFailed = true;
          SMConfig.AutoLoad = false;
        }
      }
    }
  }
}