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
      var screenSize = ImguiHelper.ScreenSize;
      var padding = new Vector2(25, 25);
      var topLeft = new Vector2(padding.x, screenSize.y * 0.4f);
      var bottomRight = screenSize - padding;
      PushDefaultStyle();
      ImGui.SetNextWindowSize(bottomRight - topLeft);
      ImGui.SetNextWindowPos(topLeft);
      ImGui.Begin("##preloader", ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.NoMove | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoSavedSettings | ImGuiWindowFlags.AlwaysAutoResize);

      ImGui.BeginColumns("##columns", 2, ImGuiOldColumnFlags.NoResize | ImGuiOldColumnFlags.GrowParentContentsSize);

      ImGui.BeginChild("##left");
      switch (SMConfig.LoadState)
      {
        case LoadState.Initializing:
          DrawInitializing();
          break;
        case LoadState.Configuring:
          DrawConfiguring();
          break;
        case LoadState.ModsLoading:
          DrawModsLoading();
          break;
        case LoadState.ModsLoaded:
          DrawModsLoaded();
          break;
      }
      ImGui.EndChild();

      ImGui.NextColumn();
      DrawLogs();
      ImGui.EndColumns();

      ImGui.End();
      PopDefaultStyle();
    }

    private static void DrawInitializing()
    {
      ImGui.Text("");
      ImGui.Spacing();
      DrawConfigTable();
    }

    private static void DrawConfiguring()
    {
      if (ImGui.Button("Load Mods"))
        SMConfig.LoadMods();
      DrawConfigTable();
    }

    private static void DrawModsLoading()
    {
      ImGui.Text("");
      ImGui.Spacing();
      DrawConfigTable();
    }

    private static void DrawModsLoaded()
    {
      if (ImGui.Button("Start Game"))
        SMConfig.StartGame();
      DrawConfigTable();
    }

    private static void DrawConfigTable()
    {
      ImGui.PushID("##config");

      var mods = SMConfig.Mods;

      if (ImGui.BeginTable("##table", 3, ImGuiTableFlags.SizingFixedFit))
      {
        ImGui.TableSetupColumn("##enabled");
        ImGui.TableSetupColumn("##type");
        ImGui.TableSetupColumn("##name", ImGuiTableColumnFlags.WidthStretch);
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
          if (ImGui.Selectable(mod.DisplayName, LogFilter == mod.Loaded?.Logger))
          {
            LogFilter = mod.Loaded?.Logger ?? Logger.Global;
            ScrollLogsToEnd = true;
          }

          if (!enabled)
              ImGui.EndDisabled();

          ImGui.PopID();
        }
        ImGui.EndTable();
      }

      ImGui.PopID();
    }

    private static Logger LogFilter = Logger.Global;
    private static bool ScrollLogsToEnd = false;
    private static int LastLogCount = 0;
    private static void DrawLogs()
    {
      ImGui.BeginChild("##logs");

      var logLines = LogFilter.Lines;
      var totalCount = logLines.TotalCount;
      if (totalCount != LastLogCount)
      {
        LastLogCount = totalCount;
        ScrollLogsToEnd = true;
      }
      var lineCount = logLines.Count;
      for (var i = 0; i < lineCount; i++)
        ImGui.Text(logLines[i]);

      if (ScrollLogsToEnd)
      {
        ScrollLogsToEnd = false;
        ImGui.SetScrollHereY();
      }

      ImGui.EndChild();
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