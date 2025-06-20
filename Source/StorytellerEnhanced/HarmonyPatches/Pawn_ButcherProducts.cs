using HarmonyLib;
using Verse;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Pawn), "ButcherProducts")]
public class Pawn_ButcherProducts
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