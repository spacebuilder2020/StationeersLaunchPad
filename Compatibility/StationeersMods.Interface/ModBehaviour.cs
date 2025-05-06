
using System;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

// adapted from github.com/jixxed/StationeersMods
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

    // These are copied over from StationeersMods. They likely don't need to be used in most cases,
    // but they are included here in case any existing mods depend on them.
    public new Object Instantiate(Object original, Vector3 position, Quaternion rotation)
    {
      if (this.contentHandler == null)
        return null;

      var obj = this.contentHandler.Instantiate(original, position, rotation);
      if (obj is GameObject gameObject)
        SceneManager.MoveGameObjectToScene(gameObject, this.gameObject.scene);

      return obj;
    }

    public new Object Instantiate(Object original) => this.Instantiate(original, Vector3.zero, Quaternion.identity);

    public new T Instantiate<T>(T original) where T : Object
    {
      if (this.contentHandler == null)
        return null;

      var obj = this.contentHandler.Instantiate(original);
      if (obj is GameObject gameObject)
        SceneManager.MoveGameObjectToScene(gameObject, this.gameObject.scene);
      return obj;
    }

    public T AddComponent<T>() where T : Component => this.AddComponent<T>(this.gameObject);

    public T AddComponent<T>(GameObject gameObject) where T : Component
    {
      if (this.contentHandler == null)
        return null;

      return this.contentHandler.AddComponent<T>(gameObject);
    }

    public Component AddComponent(Type componentType) => this.AddComponent(componentType, this.gameObject);

    public Component AddComponent(Type componentType, GameObject gameObject)
    {
      if (this.contentHandler == null)
        return null;

      return this.contentHandler.AddComponent(componentType, gameObject);
    }

    public new void Destroy(Object obj)
    {
      if (this.contentHandler == null)
        return;

      this.contentHandler.Destroy(obj);
    }
  }
}