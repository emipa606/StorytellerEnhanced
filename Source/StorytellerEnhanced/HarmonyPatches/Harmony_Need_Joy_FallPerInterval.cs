using HarmonyLib;
using RimWorld;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Need_Joy))]
[HarmonyPatch("FallPerInterval", MethodType.Getter)]
public class Harmony_Need_Joy_FallPerInterval
{
    public static void Postfix(ref float __result)
    {
        var extDiff = HarmonySetup.CurrentDifficultyDef?.GetModExtension<ModExt_Difficulty>();
        if (extDiff != null)
        {
            __result *= extDiff.needJoyFallFactor;
        }
    }
}