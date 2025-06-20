using HarmonyLib;
using Verse;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Thing), nameof(Thing.ButcherProducts))]
public class Thing_ButcherProducts
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