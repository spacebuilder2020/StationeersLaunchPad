using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace StationeersMods.Shared
{
  [Flags]
  public enum ContentType { assemblies = 2, prefabs = 4, scenes = 8 }

  public enum BootType { entrypoint = 0, prefab = 1, scene = 2, bepin = 3 }

  public class ExportSettings : ScriptableObject
  {
     public string _name;
     public string _author;
     public string _description;
     public string _version;
     public string[] _assemblies;
     public string[] _artifacts;
     public string _outputDirectory;
     public string _stationeersDirectory;
     public string _stationeersArguments;
     public ContentType _contentTypes;
     public bool _includePdbs;
     public bool _waitForDebugger;
     public BootType _bootType;
     public string _startupClass;
     public string _startupScene;
     public GameObject _startupPrefab;
  }
}