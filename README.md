# StationeersLaunchPad

A simple mod loader for Stationeers that allows you to edit mod configuration at game startup. This is compatible with Bepinex and StationeersMods mods installed locally in the home folder or downloaded from steam workshop.

## Installation

### Fresh
- Install BepInEx 5.x into game folder
  - find latest 5.x [BepInEx Release](https://github.com/BepInEx/BepInEx/releases), and download win_x64 zip
  - extract into game folder (right click game in steam, `Manage->Browse local files`)
  - should end up with `BepInEx` folder and `doorstop_config.ini` file in same folder as rocketstation.exe
- Install StationeersLaunchPad
  - download latest client zip from [Releases](https://github.com/StationeersLaunchPad/StationeersLaunchPad/releases)
  - extract into `BepInEx/plugins` folder

### Switch from StationeersMods
- Remove `StationeersMods` folder from `Bepinex/plugins` in game folder
  - to open game folder: right click game in steam, `Manage->Browse local files`
- Install StationeersLaunchPad
  - download latest client zip from [Releases](https://github.com/StationeersLaunchPad/StationeersLaunchPad/releases)
  - extract into `BepInEx/plugins` folder

## Usage

- Install mods into `%HOME%/documents/my games/stationeers/mods` or download them from steam workshop.
- Start game. Mods will automatically load
- If you want to reorder or enable/disable mods, click the loading window at the bottom when the game first opens

## Dedicated Server

- Install Bepinex 5.x into dedicated server folder
  - find latest 5.x [BepInEx Release](https://github.com/BepInEx/BepInEx/releases), and download win_x64 zip
  - extract into game folder (right click game in steam, `Manage->Browse local files`)
  - should end up with `BepInEx` folder and `doorstop_config.ini` file in same folder as `rocketstation_DedicatedServer.exe`
- Install StationeersLaunchPad
  - download latest client zip from [Releases](https://github.com/StationeersLaunchPad/StationeersLaunchPad/releases)
  - extract into `BepInEx/plugins` folder
- In the game client, click the loading window at the bottom on startup to open configuration
  - enable/disable and reorder mods to match what you want installed on the server
  - click `Export Mod Package` to create a zip file containing the enabled mods and config file
  - extract the zip file into the dedicated server folder (should create `modconfig.xml` and `mods` folder in same folder as `rocketstation_DedicatedServer.exe`)