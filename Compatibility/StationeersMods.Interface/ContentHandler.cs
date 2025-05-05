
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

using Object = UnityEngine.Object;

// adapted from github.com/jixxed/StationeersMods
namespace StationeersMods.Interface
{
  public interface IResource
  {
    string name { get; }
    void Load();
    void Unload();
    void LoadAsync();
  }

  public class DummyResource : IResource
  {
    public DummyResource(string name) { this.name = name; }

    public string name { get; private set; }
    public void Load() { }
    public void LoadAsync() { }
    public void Unload() { }
  }

  public class ContentHandler
  {
    public ContentHandler(IResource mod, ReadOnlyCollection<IResource> modScenes, ReadOnlyCollection<GameObject> prefabs)
    {
      this.mod = mod;
      this.modScenes = modScenes;
      this.prefabs = prefabs;
    }

    private List<GameObject> gameObjects = new();

    public IResource mod { get; }
    public ReadOnlyCollection<IResource> modScenes { get; }
    public ReadOnlyCollection<GameObject> prefabs { get; }

    public T AddComponent<T>(GameObject gameObject) where T : Component
    {
      var component = gameObject.AddComponent<T>();
      InitializeComponent(component);
      return component;
    }

    public Component AddComponent(Type componentType, GameObject gameObject)
    {
      var component = gameObject.AddComponent(componentType);
      InitializeComponent(component);
      return component;
    }

    private void InitializeComponent(Component component)
    {
      if (component is IModHandler modHandler)
        modHandler.OnLoaded(this);
    }

    public T Instantiate<T>(T original) where T : Object
    {
      var obj = Object.Instantiate(original);
      InitializeObject(obj);
      return obj;
    }

    public Object Instantiate(Object original, Vector3 position, Quaternion rotation)
    {
      var obj = Object.Instantiate(original, position, rotation);
      InitializeObject(obj);
      return obj;
    }

    public Object Instantiate(Object original)
    {
      return Instantiate(original, Vector3.zero, Quaternion.identity);
    }

    private void InitializeObject(Object obj)
    {
      if (obj is GameObject gameObject)
      {
        this.gameObjects.Add(gameObject);
        InitializeGameObject(gameObject);
      }
      else if (obj is Component component)
      {
        this.gameObjects.Add(component.gameObject);
        InitializeComponent(component);
      }
    }

    private void InitializeGameObject(GameObject go)
    {
      foreach (var component in go.GetComponentsInChildren<Component>())
        InitializeComponent(component);
    }

    public void Destroy(Object obj)
    {
      if (obj == null)
        return;

      if (obj is GameObject gameObject)
        gameObjects.Remove(gameObject);

      Object.Destroy(obj);
    }

    public void Clear()
    {
      foreach (var gameObject in gameObjects)
        if (gameObject != null)
          Object.Destroy(gameObject);

      gameObjects.Clear();
    }
  }
}