using System;
using System.Text;
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
      if (GameManager.IsBatchMode)
        return;
      PushDefaultStyle();

      if (SMConfig.AutoLoad)
        DrawAutoLoad();
      else
        DrawManualLoad();

      PopDefaultStyle();
    }

    private static void DrawAutoLoad()
    {
      var screenSize = ImguiHelper.ScreenSize;
      var padding = new Vector2(25, 25);
      var topLeft = new Vector2(padding.x, screenSize.y - 100f - padding.y);
      var bottomRight = screenSize - padding;

      ImGui.SetNextWindowSize(bottomRight - topLeft);
      ImGui.SetNextWindowPos(topLeft);
      ImGui.Begin("##preloaderauto", ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.NoMove | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoSavedSettings);

      var autoTime = (int)Math.Ceiling(SMConfig.AutoWaitTime - SMConfig.AutoStopwatch.Elapsed.TotalSeconds);

      ImGui.Text("SMPreloader " + (SMConfig.LoadState switch
      {
        LoadState.Initializing => "Initializing",
        LoadState.Configuring => $"Loading mods in {autoTime}",
        LoadState.ModsLoading => "Loading mods",
        LoadState.ModsLoaded => $"Starting game in {autoTime}",
        _ => "",
      }));

      var logCount = Logger.Global.Lines.Count;
      if (logCount > 0)
        DrawLogLine(Logger.Global.Lines[logCount - 1]);
      else
        ImGui.Text("");

      ImGui.TextColored(Vector4.one * 0.5f, "click to configure");

      if (ImGui.IsWindowHovered() && ImGui.IsMouseClicked(ImGuiMouseButton.Left))
        SMConfig.AutoLoad = false;

      ImGui.End();
    }

    private static void DrawManualLoad()
    {
      var screenSize = ImguiHelper.ScreenSize;
      var padding = new Vector2(25, 25);
      var topLeft = new Vector2(padding.x, screenSize.y * 0.4f);
      var bottomRight = screenSize - padding;

      ImGui.SetNextWindowSize(bottomRight - topLeft);
      ImGui.SetNextWindowPos(topLeft);
      ImGui.Begin("##preloadermanual", ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.NoMove | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoSavedSettings);

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
    }

    private static void DrawInitializing()
    {
      ImGui.Text("");
      ImGui.Spacing();
      DrawConfigTable();
    }

    private static bool ConfigChanged = false;
    private static void DrawConfiguring()
    {
      ConfigChanged = false;

      if (ImGui.Button("Load Mods"))
        SMConfig.LoadState = LoadState.ModsLoading;
      ImGui.SameLine();
      DrawExportButton();
      ImGui.SameLine();
      if (ImGui.Checkbox("Autosort", ref SMConfig.AutoSort))
        ConfigChanged = true;

      DrawConfigTable(edit: true);

      if (ConfigChanged)
      {
        if (SMConfig.AutoSort)
          SMConfig.SortByDeps();
        SMConfig.SaveConfig();
      }
    }

    private static void DrawExportButton()
    {
      if (ImGui.Button("Export Mod Package"))
        SMConfig.ExportModPackage();
      if (ImGui.IsItemHovered())
        ImGui.SetTooltip("Create a zip file with all enabled mods for dedicated servers");
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
        SMConfig.LoadState = LoadState.GameRunning;
      ImGui.SameLine();
      DrawExportButton();

      DrawLoadTable();
    }

    private static ModInfo DraggingMod = null;
    private static void DrawConfigTable(bool edit = false)
    {
      var mods = SMConfig.Mods;
      var hoverIndex = -1;

      if (!ImGui.IsMouseDown(ImGuiMouseButton.Left))
        DraggingMod = null;

      var draggingIndex = -1;
      if (DraggingMod != null)
        draggingIndex = SMConfig.Mods.IndexOf(DraggingMod);

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
            ConfigChanged = true;

          ImGui.TableNextColumn();
          ImGui.Selectable($"##rowdrag", mod == DraggingMod, ImGuiSelectableFlags.SpanAllColumns);
          if (ImGui.IsItemHovered(ImGuiHoveredFlags.AllowWhenBlockedByActiveItem))
          {
            hoverIndex = i;
            if (DraggingMod == null && ImGui.IsMouseClicked(ImGuiMouseButton.Left))
            {
              DraggingMod = mod;
              draggingIndex = i;
            }
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

      if (draggingIndex != -1 && hoverIndex != -1 && draggingIndex != hoverIndex)
      {
        while (draggingIndex < hoverIndex)
        {
          (mods[draggingIndex + 1], mods[draggingIndex]) = (mods[draggingIndex], mods[draggingIndex + 1]);
          draggingIndex++;
        }
        while (draggingIndex > hoverIndex)
        {
          (mods[draggingIndex - 1], mods[draggingIndex]) = (mods[draggingIndex], mods[draggingIndex - 1]);
          draggingIndex--;
        }
        ConfigChanged = true;
      }
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
          else if (mod.Loaded.LoadFailed)
            ImGui.TextColored(new Vector4(1, 0, 0, 1), "X");
          else if (!mod.Loaded.LoadFinished)
            ImGui.Text("...");
          else
            ImGui.TextColored(new Vector4(0, 1, 0, 1), "+");

          ImGui.TableNextColumn();
          var selected = LogFilter == mod.Loaded?.Logger;
          if (ImGui.Selectable("##logselect", selected, ImGuiSelectableFlags.SpanAllColumns))
          {
            if (selected)
              LogFilter = Logger.Global;
            else
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
      ImGui.BeginChild("##logs", ImGuiWindowFlags.HorizontalScrollbar);

      var logLines = LogFilter.Lines;
      var totalCount = logLines.TotalCount;
      if (totalCount != LastLogCount)
      {
        LastLogCount = totalCount;
        ScrollLogsToEnd = true;
      }
      var lineCount = logLines.Count;
      for (var i = 0; i < lineCount; i++)
        DrawLogLine(logLines[i]);

      if (ScrollLogsToEnd)
      {
        ScrollLogsToEnd = false;
        ImGui.SetScrollHereY();
      }

      if (ImGui.IsWindowHovered())
      {
        ImGui.SetTooltip("Click to copy logs");
        if (ImGui.IsMouseClicked(ImGuiMouseButton.Left))
        {
          var logText = new StringBuilder();
          for (var i = 0; i < lineCount; i++)
            logText.AppendLine(logLines[i].Text);
          ImGui.SetClipboardText(logText.ToString());
          LogFilter.Log("Logs copied to clipboard");
        }
      }

      ImGui.EndChild();
    }

    private static void DrawLogLine(LogLine line)
    {
      if (line.Type == LogType.Log)
        ImGui.Text(line.Text);
      else if (line.Type == LogType.Warning)
        ImGui.TextColored(new Vector4(0.7f, 0.7f, 0, 1), line.Text);
      else
        ImGui.TextColored(new Vector4(1, 0, 0, 1), line.Text);
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