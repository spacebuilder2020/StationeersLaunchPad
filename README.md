# StationeersModPreloader (final name TBD)

A simple mod loader for Stationeers that allows you to edit mod configuration at game startup. This is compatible with Bepinex and StationeersMods mods installed locally in the home folder or downloaded from steam workshop.

## Installation

### Fresh
- Install Bepinex 5.x into game folder
- Copy SMPreloader dlls into Bepinex/plugins in game folder

### Switch from StationeersMods
- Remove StationeersMods folder from Bepinex/plugins in game folder
- Copy SMPreloader dlls into Bepinex/plugins in game folder

## Usage

- Install mods into `%HOME%/documents/my games/stationeers/mods` or download them from steam workshop.
- Start game. Mods will automatically load
- If you want to reorder or enable/disable mods, click the loading window at the bottom when the game first opens

## Dedicated Server

- Install Bepinex 5.x into dedicated server folder
- Copy SMPreloader dlls into Bepinex/plugins in dedicated server folder
- On the regular game client, click the loading window at the bottom on startup to open configuration
  - enable/disable and reorder mods to match what you want installed on the server
  - click `Export Mod Package` to create a zip file containing the enabled mods and config file
  - extract the zip file into the dedicated server folder (should create `modconfig.xml` and `mods` folder in same folder as `rocketstation_DedicatedServer.exe`)