using System.Collections.Generic;
using System.Reflection.Emit;
using HarmonyLib;

namespace CaughtIn4K.Patches;

[HarmonyPatch(typeof(VideoCamera))]
internal class VideoCamera_Patch {

    // This method patches the CreateRenderTexture Method in the VideoCamera class
    // and replaces the hardcoded values (420, 420) with the custom values

    [HarmonyTranspiler]
    [HarmonyPatch("CreateRenderTexture")]
    private static IEnumerable<CodeInstruction> UpdateRenderTexture(IEnumerable<CodeInstruction> instructions) {
        return new CodeMatcher(instructions, (ILGenerator)null).MatchForward(false, (CodeMatch[])(object)new CodeMatch[1]
			{
				new CodeMatch((OpCode?)OpCodes.Ldc_I4, (object)420, (string)null) // match a hardcoded 420 int parameter
			}).SetOperandAndAdvance((object)CaughtIn4kPlugin.config.RESOLUTION_X.Value).MatchForward(false, (CodeMatch[])(object)new CodeMatch[1] // replace with custom value
			{
				new CodeMatch((OpCode?)OpCodes.Ldc_I4, (object)420, (string)null) // do it again
			})
				.SetOperandAndAdvance((object)CaughtIn4kPlugin.config.RESOLUTION_Y.Value)
				.InstructionEnumeration();
    }
}