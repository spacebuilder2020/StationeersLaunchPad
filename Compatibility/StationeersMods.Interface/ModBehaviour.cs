
using System;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace StationeersMods.Interface
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class StationeersMod : BepInPlugin
  {
    public StationeersMod(string GUID, string Name, string Version) : base(GUID, Name, Version) { }
  }

  public interface IModHandler
  {
    void OnLoaded(ContentHandler contentHandler);

    void OnUnloaded();
  }

  public abstract class ModBehaviour : MonoBehaviour, IModHandler
  {
    public ConfigFile Config { get; }
    public ContentHandler contentHandler { get; set; }

    public virtual void OnLoaded(ContentHandler contentHandler)
    {
      this.contentHandler = contentHandler;
    }

    protected ModBehaviour()
    {
    }

    public static StationeersMod GetMetadata(object plugin)
    {
      var attr = plugin.GetType().GetCustomAttribute<StationeersMod>();
      return attr;
    }

    public void OnUnloaded() { }
  }
}