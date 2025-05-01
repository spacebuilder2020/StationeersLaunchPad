using System.Collections;
using System.Reflection;
using Assets.Scripts;
using ImGuiNET;
using UI.ImGuiUi;
using UnityEngine;

namespace SMPreloader
{
  public static class SMPreloaderGUI
  {
    public static bool IsActive = true;

    public static void Draw()
    {
      var minSize = new Vector2(400, 400);
      var padding = new Vector2(25, 25);
      var maxSize = ImguiHelper.ScreenSize - padding * 2;
      PushDefaultStyle();
      ImGui.SetNextWindowSizeConstraints(minSize, maxSize);
      ImGui.SetNextWindowPos(padding);
      ImGui.Begin("##preloader", ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.NoMove | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoSavedSettings | ImGuiWindowFlags.AlwaysAutoResize | ImGuiWindowFlags.AlwaysVerticalScrollbar);

      var loading = SMConfig.Loading;
      if (loading)
        ImGui.BeginDisabled();

      if (SMConfig.ModsLoaded)
      {
        if (ImGui.Button("Start Game") && !loading)
          SMConfig.StartGame();
      }
      else
      {
        if (ImGui.Button("Load Mods") && !loading)
          SMConfig.LoadMods();
      }

      if (loading)
        ImGui.EndDisabled();

      DrawConfigTable();

      ImGui.End();
      PopDefaultStyle();
    }

    private static void DrawConfigTable()
    {
      ImGui.PushID("##config");

      var mods = SMConfig.Mods;

      if (ImGui.BeginTable("##table", 3))
      {
        for (var i = 0; i < mods.Count; i++)
        {
          ImGui.TableNextRow();

          ImGui.PushID(i);

          var mod = mods[i];
          var enabled = mod.Enabled;

          ImGui.TableNextColumn();
          ImGui.Checkbox("##enabled", ref enabled);

          if (!enabled)
            ImGui.BeginDisabled();

          ImGui.TableNextColumn();
          ImGui.Text(mod.Source.ToString());

          ImGui.TableNextColumn();
          ImGui.Text(mod.DisplayName);

          if (!enabled)
            ImGui.EndDisabled();

          ImGui.PopID();
        }
        ImGui.EndTable();
      }

      var logLines = Logger.Global.Lines;
      var lineCount = logLines.Count;
      for (var i = lineCount - 1; i >= 0; i--)
        ImGui.Text(logLines[i]);

      ImGui.PopID();
    }

    private static Vector4[] _colors;
    private static void PushDefaultStyle()
    {
      if (_colors == null)
      {
        // initialize style colors
        _colors = new Vector4[(int)ImGuiCol.COUNT];
        for (var i = 0; i < (int)ImGuiCol.COUNT; i++)
        {
          _colors[i] = ImGui.ColorConvertU32ToFloat4(ImGui.GetColorU32((ImGuiCol)i));
          // premultiply alpha and set to opaque if not fully transparent
          _colors[i] = _colors[i] * _colors[i][3];
          if (_colors[i][3] != 0f)
          {
            _colors[i][3] = 1f;
          }
        }
      }

      for (var i = (ImGuiCol)0; i < ImGuiCol.COUNT; i++)
      {
        ImGui.PushStyleColor(i, _colors[(int)i]);
      }
      ImGui.PushStyleVar(ImGuiStyleVar.CellPadding, new Vector2(3, 2));
      ImGui.PushStyleVar(ImGuiStyleVar.FramePadding, new Vector2(3, 2));
      ImGui.PushStyleVar(ImGuiStyleVar.WindowRounding, 3);
      ImGui.PushStyleVar(ImGuiStyleVar.Alpha, 1);
    }

    private static void PopDefaultStyle()
    {
      ImGui.PopStyleVar(4);
      ImGui.PopStyleColor((int)ImGuiCol.COUNT);
    }
  }
}