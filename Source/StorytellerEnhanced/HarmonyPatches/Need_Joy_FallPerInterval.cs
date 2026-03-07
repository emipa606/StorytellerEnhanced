using HarmonyLib;
using RimWorld;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Need_Joy), "FallPerInterval", MethodType.Getter)]
public class Need_Joy_FallPerInterval
{
    public static void Postfix(ref float __result)
    {
        var extDiff = HarmonySetup.CurrentDifficultyDefExtension;
        if (extDiff != null)
        {
            __result *= extDiff.needJoyFallFactor;
        }
    }
}