
using System;
using BepInEx.Configuration;
using UnityEngine;

namespace CaughtIn4K.Config;

internal class CaughtIn4KConfig
{
    internal ConfigEntry<int> RESOLUTION_X; // horizontal resolution
    internal ConfigEntry<int> RESOLUTION_Y; // vertical resolution

    internal CaughtIn4KConfig(ConfigFile cfgFile) {
        RESOLUTION_X = cfgFile.Bind<int>("Main", "ResolutionX", 840, new ConfigDescription("The Video Camera's Horizontal Resolution\nDifferent aspect ratios than the vanilla one (1:1) actually seem to work reasonably fine."));
        RESOLUTION_Y = cfgFile.Bind<int>("Main", "ResolutionY", 840, new ConfigDescription("The Video Camera's Vertical Resolution\nDefault values are 2x the vanilla resolution. Be that raising the total resolution (x*y) too high can cause huge file sizes, CPU utilization and RAM Usage."));
    }

}
