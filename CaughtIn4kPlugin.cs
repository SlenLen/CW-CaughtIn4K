using System.Reflection;
using BepInEx;
using HarmonyLib;
using CaughtIn4K.Config;

namespace CaughtIn4K;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class CaughtIn4kPlugin : BaseUnityPlugin
{
    public static CaughtIn4kPlugin Instance { get; private set; }
    internal static Harmony Harmony { get; private set; }
    internal static CaughtIn4KConfig config { get; private set; }

    private void Awake()
    {
        Instance = this;
        config = new CaughtIn4KConfig(((BaseUnityPlugin)(this)).Config); // Create config
        Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID); // Apply patches

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }
}
