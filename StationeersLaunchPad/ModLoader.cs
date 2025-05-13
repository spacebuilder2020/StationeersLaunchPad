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

namespace StationeersLaunchPad
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
          var assembly = frame.GetMethod()?.DeclaringType?.Assembly;
          if (assembly != null && AssemblyToMod.TryGetValue(assembly, out mod))
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

    public static List<Type> FindAnyStationeersModsEntrypoints(List<Assembly> assemblies)
    {
      var result = new List<Type>();
      foreach (var assembly in assemblies)
      {
        foreach (var type in assembly.GetTypes())
        {
          if (typeof(ModBehaviour).IsAssignableFrom(type))
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

    public const string DEFAULT_METHOD = "OnLoaded";
    public static List<(Type, MethodInfo)> FindDefaultEntrypoints(List<Assembly> assemblies)
    {
      var result = new List<(Type, MethodInfo)>();
      foreach (var assembly in assemblies)
      {
        var name = assembly.GetName().Name;
        var defType = assembly.GetType(name);
        if (defType == null || !typeof(MonoBehaviour).IsAssignableFrom(defType))
          continue;

        var defMethod = defType.GetMethod(DEFAULT_METHOD, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[] { typeof(List<GameObject>) }, null);
        if (defMethod == null)
          continue;
        result.Add((defType, defMethod));
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
      // load in 3 steps:
      // - load all assemblies in order without resolving types
      // - resolve types in assemblies
      // - load asset bundles, find and load entry points
      // each step is done in the order the mods are configured
      // if a mod fails to load, the following steps will be skipped for that mod

      var enabledMods = LaunchPadConfig.Mods.Where(mod => mod.Enabled && mod.Source != ModSource.Core).ToList();

      static void modFailed(LoadedMod mod, Exception ex)
      {
        mod.Logger.LogException(ex);
        mod.LoadFailed = true;
        LaunchPadConfig.AutoLoad = false;
      }

      foreach (var modInfo in enabledMods)
      {
        var mod = new LoadedMod(modInfo);
        modInfo.Loaded = mod;
        ModLoader.LoadedMods.Add(mod);

        try
        {
          await mod.LoadAssembliesSerial();
        }
        catch (Exception ex)
        {
          modFailed(mod, ex);
        }
      }
      foreach (var modInfo in enabledMods)
      {
        var mod = modInfo.Loaded;
        if (mod.LoadFailed) continue;
        try
        {
          mod.ResolveAssemblies();
        }
        catch (Exception ex)
        {
          modFailed(mod, ex);
        }
      }
      foreach (var modInfo in enabledMods)
      {
        var mod = modInfo.Loaded;
        if (mod.LoadFailed) continue;
        try
        {
          await mod.LoadAssetsSerial();
          await mod.FindEntrypoints();
          await mod.LoadEntrypoints();
        }
        catch (Exception ex)
        {
          modFailed(mod, ex);
        }
      }
    }
  }
}