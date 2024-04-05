
using System;
using BepInEx.Configuration;
using UnityEngine;

namespace CaughtIn4K.Config;

internal class CaughtIn4KConfig
{
    internal ConfigEntry<int> RESOLUTION_X; // horizontal resolution
    internal ConfigEntry<int> RESOLUTION_Y; // vertical resolution

    internal CaughtIn4KConfig(ConfigFile cfgFile) {
        RESOLUTION_X = cfgFile.Bind<int>("Main", "ResolutionX", 840, new ConfigDescription("The Video Camera's Horizontal Resolution\nIDK how well aspect ratios other than 1:1 work, so I don't recommend setting the side lengths to different values."));
        RESOLUTION_Y = cfgFile.Bind<int>("Main", "ResolutionY", 840, new ConfigDescription("The Video Camera's Vertical Resolution\nDefault values are 2x the vanilla resolution. Be aware that raising the resoltion increases the video file size very quickly."));
    }

}