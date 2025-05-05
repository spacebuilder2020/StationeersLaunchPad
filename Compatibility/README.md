# Compatibility wrappers

These are stripped down implementations of the StationeersMods dlls that mods directly link to. They have to exist in some form so we need a basic implementation here. These are not complete yet so there may still be mods that won't load if they call parts of StationeersMods that haven't been implemented here.

ImGui is not included in the dedicated server build, but we don't yet have a way of handling separate mod builds for dedicated servers, so a noop shim is included here to avoid load errors. Ideally these would never be actually called, but hopefully shouldn't crash if they are.