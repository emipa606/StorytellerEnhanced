using HarmonyLib;
using Verse;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Thing), nameof(Thing.ButcherProducts))]
public class Thing_ButcherProducts
{
    public static void Prefix(ref float efficiency)
    {
        var extDiff = HarmonySetup.CurrentDifficultyDefExtension;
        if (extDiff != null)
        {
            efficiency *= extDiff.butcherProductFactor;
        }
    }
}