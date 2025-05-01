using System;
using Assets.Scripts;
using Assets.Scripts.Objects;
using UnityEngine;

namespace StationeersMods.Interface
{
  public class StationeersModsUtility
  {
    public static Thing FindPrefab(string prefabName) => WorldManager.Instance.SourcePrefabs.Find(prefab => prefab != null & prefab.PrefabName == prefabName);
    public static Item FindTool(StationeersTool tool) => FindPrefab(tool.PrefabName) as Item;
    public static Material[] GetBlueprintMaterials(int size)
    {
      var blueprintMaterial = FindPrefab("StructureFrame").Blueprint.GetComponent<MeshRenderer>().materials[0];
      var materials = new Material[size];
      for (var i = 0; i < size; i++)
        materials[i] = blueprintMaterial;
      return materials;
    }
    public static Material GetMaterial(StationeersColor color, ShaderType shaderType)
    {
      var swatch = GameManager.Instance.CustomColors[(int)color];
      return shaderType switch
      {
        ShaderType.NORMAL => swatch.Normal,
        ShaderType.EMISSIVE => swatch.Emissive,
        ShaderType.CUTABLE => swatch.Cutable,
        _ => throw new ArgumentOutOfRangeException(nameof(shaderType), shaderType, null)
      };
    }
  }

  public class StationeersTool
  {
    public static StationeersTool ANGLE_GRINDER = new("ItemAngleGrinder");
    public static StationeersTool WELDER = new("ItemWeldingTorch");
    public static StationeersTool CABLE_CUTTERS = new("ItemWireCutters");
    public static StationeersTool CROWBAR = new("ItemCrowbar");
    public static StationeersTool DRILL = new("ItemDrill");
    public static StationeersTool MINING_DRILL = new("ItemMiningDrill");
    public static StationeersTool PICKAXE = new("ItemPickaxe");
    public static StationeersTool DUCT_TAPE = new("ItemDuctTape");
    public static StationeersTool FIRE_EXTINGUISHER = new("ItemFireExtinguisher");
    public static StationeersTool LABELLER = new("ItemLabeller");
    public static StationeersTool WRENCH = new("ItemWrench");
    public static StationeersTool SCREWDRIVER = new("ItemScrewdriver");

    public string PrefabName { get; private set; }
    public StationeersTool(string prefabName)
    {
      this.PrefabName = prefabName;
    }
  }

  public enum StationeersColor
  {
    BLUE = 0,
    GRAY = 1,
    GREEN = 2,
    ORANGE = 3,
    RED = 4,
    YELLOW = 5,
    WHITE = 6,
    BLACK = 7,
    BROWN = 8,
    KHAKI = 9,
    PINK = 10,
    PURPLE = 11
  }

  public enum ShaderType
  {
    EMISSIVE, NORMAL, CUTABLE
  }
}