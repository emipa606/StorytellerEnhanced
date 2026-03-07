using HarmonyLib;
using Verse;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Pawn), nameof(Pawn.ButcherProducts))]
public class Pawn_ButcherProducts
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