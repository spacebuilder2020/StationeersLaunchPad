
using System.Reflection;
using System.Threading.Tasks;
using Assets.Scripts;
using Assets.Scripts.Networking.Transports;
using Assets.Scripts.Serialization;
using BepInEx;
using Cysharp.Threading.Tasks;
using HarmonyLib;
using Steamworks;
using UnityEngine;
using UnityEngine.LowLevel;

namespace StationeersLaunchPad
{
  [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
  public class LaunchPadPlugin : BaseUnityPlugin
  {
    public const string pluginGuid = "stationeers.launchpad";
    public const string pluginName = "StationeersLaunchPad";
    public const string pluginVersion = "0.1.0";

    void Awake()
    {
      if (Harmony.HasAnyPatches(pluginGuid))
        return;

      var harmony = new Harmony(pluginGuid);
      harmony.PatchAll();

      var unityLogger = Debug.unityLogger as UnityEngine.Logger;
      unityLogger.logHandler = new LogWrapper(unityLogger.logHandler);

      var playerLoop = PlayerLoop.GetCurrentPlayerLoop();
      PlayerLoopHelper.Initialize(ref playerLoop);

      LaunchPadConfig.Run();
    }
  }

  [HarmonyPatch]
  static class LaunchPadPatches
  {
    [HarmonyPatch(typeof(SplashBehaviour), "Awake"), HarmonyPrefix]
    static bool SplashAwake(SplashBehaviour __instance)
    {
      LaunchPadConfig.SplashBehaviour = __instance;
      Application.targetFrameRate = 60;
      typeof(SplashBehaviour).GetProperty("IsActive").SetValue(null, true);
      return false;
    }

    [HarmonyPatch(typeof(SplashBehaviour), nameof(SplashBehaviour.Draw)), HarmonyPrefix]
    static bool SplashDraw()
    {
      if (LaunchPadGUI.IsActive)
      {
        LaunchPadGUI.Draw();
        return false;
      }
      return true;
    }

    [HarmonyPatch(typeof(WorldManager), "LoadDataFiles"), HarmonyPostfix]
    static void LoadDataFiles()
    {
      // Some global menus (printer recipe selection, hash generator selection) load strings
      // before mod xml files are loaded in. This forces a reload of all those strings.
      Localization.OnLanguageChanged.Invoke();
    }

    [HarmonyPatch(typeof(SteamUGC), nameof(SteamUGC.DeleteFileAsync)), HarmonyPrefix]
    static bool DeleteFileAsync(ref Task<bool> __result)
    {
      // don't remove workshop items when the owner unsubscribes
      __result = Task.Run(() => true);
      return false;
    }

    // we patch PublishMod to add the changelog, but its done in 2 steps.
    // first we prefix patch PublishMod to save the changelog
    // then we prefix patch Workshop_PublishItemAsync to add the saved changelog
    // we check the directory path of the mod matches just to be sure something weird didnt happen
    static string SavedChangeLog = "";
    static string SavedPath = "";
    [HarmonyPatch(typeof(WorkshopMenu), "PublishMod"), HarmonyPrefix]
    static void PublishMod(WorkshopModListItem ____selectedModItem)
    {
      var mod = ____selectedModItem.Data;
      var about = XmlSerialization.Deserialize<ModAbout>(mod.AboutXmlPath, "ModMetadata");
      SavedChangeLog = about.ChangeLog;
      SavedPath = mod.DirectoryPath;
    }
    [HarmonyPatch(typeof(SteamTransport), nameof(SteamTransport.Workshop_PublishItemAsync)), HarmonyPrefix]
    static void Workshop_PublishItemAsync(SteamTransport.WorkShopItemDetail detail)
    {
      if (detail.Path == SavedPath)
        detail.ChangeNote = SavedChangeLog;
    }
  }
}