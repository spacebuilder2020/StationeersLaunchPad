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
      DrawConfigTable(edit: true);
    }

    private static void DrawModsLoading()
    {
      ImGui.Text("");
      ImGui.Spacing();
      DrawLoadTable();
    }

    private static void DrawModsLoaded()
    {
      if (ImGui.Button("Start Game"))
        SMConfig.StartGame();
      DrawLoadTable();
    }

    private static int DraggingIndex = -1;
    private static void DrawConfigTable(bool edit = false)
    {
      var mods = SMConfig.Mods;
      var changed = false;
      var hoverIndex = -1;

      if (!ImGui.IsMouseDown(ImGuiMouseButton.Left))
        DraggingIndex = -1;

      if (!edit)
        ImGui.BeginDisabled();

      if (ImGui.BeginTable("##configtable", 3, ImGuiTableFlags.SizingFixedFit))
      {
        ImGui.TableSetupColumn("##enabled");
        ImGui.TableSetupColumn("##type");
        ImGui.TableSetupColumn("##name", ImGuiTableColumnFlags.WidthStretch);
        for (var i = 0; i < mods.Count; i++)
        {
          ImGui.TableNextRow();

          ImGui.PushID(i);

          var mod = mods[i];

          ImGui.TableNextColumn();
          if (ImGui.Checkbox("##enabled", ref mod.Enabled))
            changed = true;

          ImGui.TableNextColumn();
          ImGui.Selectable($"##rowdrag", i == DraggingIndex, ImGuiSelectableFlags.SpanAllColumns);
          if (ImGui.IsItemHovered(ImGuiHoveredFlags.AllowWhenBlockedByActiveItem))
          {
            hoverIndex = i;
            if (DraggingIndex == -1 && ImGui.IsMouseClicked(ImGuiMouseButton.Left))
              DraggingIndex = i;
          }
          ImGui.SameLine();
          ImGui.Text($"{mod.Source}");

          ImGui.TableNextColumn();
          ImGui.Text(mod.DisplayName);

          ImGui.PopID();
        }
        ImGui.EndTable();
      }

      if (!edit)
        ImGui.EndDisabled();

      if (DraggingIndex != -1 && hoverIndex != -1 && DraggingIndex != hoverIndex)
      {
        while (DraggingIndex < hoverIndex)
        {
          (mods[DraggingIndex + 1], mods[DraggingIndex]) = (mods[DraggingIndex], mods[DraggingIndex + 1]);
          DraggingIndex++;
        }
        while (DraggingIndex > hoverIndex)
        {
          (mods[DraggingIndex - 1], mods[DraggingIndex]) = (mods[DraggingIndex], mods[DraggingIndex - 1]);
          DraggingIndex--;
        }
        changed = true;
      }

      if (changed)
        SMConfig.SaveConfig();
    }

    private static void DrawLoadTable()
    {
      var mods = SMConfig.Mods;

      if (ImGui.BeginTable("##loadtable", 3, ImGuiTableFlags.SizingFixedFit))
      {
        ImGui.TableSetupColumn("##state", 30f);
        ImGui.TableSetupColumn("##type");
        ImGui.TableSetupColumn("##name", ImGuiTableColumnFlags.WidthStretch);
        for (var i = 0; i < mods.Count; i++)
        {
          var mod = mods[i];
          if (!mod.Enabled)
            continue;

          ImGui.PushID(i);

          ImGui.TableNextRow();
          ImGui.TableNextColumn();

          if (mod.Loaded == null)
            ImGui.Text("");
          else if (!mod.Loaded.LoadFinished)
            ImGui.Text("...");
          else
            ImGui.TextColored(new Vector4(0, 1, 0, 1), "X");

          ImGui.TableNextColumn();
          if (ImGui.Selectable("##logselect", LogFilter == mod.Loaded?.Logger, ImGuiSelectableFlags.SpanAllColumns))
          {
            LogFilter = mod.Loaded?.Logger ?? Logger.Global;
            ScrollLogsToEnd = true;
          }
          ImGui.SameLine();
          ImGui.Text(mod.Source.ToString());

          ImGui.TableNextColumn();
          ImGui.Text(mod.DisplayName);

          ImGui.PopID();
        }
        ImGui.EndTable();
      }
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
            _colors[i][3] = 1f;
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