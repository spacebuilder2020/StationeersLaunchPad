
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace StationeersMods.Interface
{
  public interface IResource
  {
    string name { get; }
    void Load();
    void Unload();
    void LoadAsync();
  }

  public class ContentHandler
  {
    public ContentHandler(IResource mod, ReadOnlyCollection<IResource> modScenes, ReadOnlyCollection<GameObject> prefabs)
    {
      this.mod = mod;
      this.modScenes = modScenes;
      this.prefabs = prefabs;
    }

    public IResource mod { get; }
    public ReadOnlyCollection<IResource> modScenes { get; }
    public ReadOnlyCollection<GameObject> prefabs { get; }
  }
}