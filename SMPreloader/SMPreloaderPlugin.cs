
using System.Reflection;
using Assets.Scripts;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace SMPreloader
{
  [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
  public class SMPreloaderPlugin : BaseUnityPlugin
  {
    public const string pluginGuid = "unlucky.smpreloader";
    public const string pluginName = "SMPreloader";
    public const string pluginVersion = "0.1";

    void Awake()
    {
      if (Harmony.HasAnyPatches(pluginGuid))
        return;

      var harmony = new Harmony(pluginGuid);
      harmony.PatchAll();

      var unityLogger = Debug.unityLogger as UnityEngine.Logger;
      unityLogger.logHandler = new LogWrapper(unityLogger.logHandler);

      SMConfig.Run();
    }
  }

  [HarmonyPatch]
  static class PreloaderPatches
  {
    [HarmonyPatch(typeof(SplashBehaviour), "Awake"), HarmonyPrefix]
    static bool SplashAwake(SplashBehaviour __instance)
    {
      SMConfig.SplashBehaviour = __instance;
      Application.targetFrameRate = 60;
      typeof(SplashBehaviour).GetProperty("IsActive").SetValue(null, true);
      return false;
    }

    [HarmonyPatch(typeof(SplashBehaviour), nameof(SplashBehaviour.Draw)), HarmonyPrefix]
    static bool SplashDraw()
    {
      if (SMPreloaderGUI.IsActive)
      {
        SMPreloaderGUI.Draw();
        return false;
      }
      return true;
    }
  }
}