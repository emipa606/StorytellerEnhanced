using HarmonyLib;
using Verse;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Thing))]
[HarmonyPatch("ButcherProducts")]
public class Harmony_Thing_ButcherProducts
{
    public static void Prefix(ref float efficiency)
    {
        var extDiff = HarmonySetup.CurrentDifficultyDef?.GetModExtension<ModExt_Difficulty>();
        if (extDiff != null)
        {
            efficiency *= extDiff.butcherProductFactor;
        }
    }
}