using HarmonyLib;
using RimWorld;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Thought))]
[HarmonyPatch("MoodOffset")]
public class Harmony_Thought_MoodOffset
{
    public static void Postfix(ref float __result)
    {
        var extDiff = HarmonySetup.CurrentDifficultyDef?.GetModExtension<ModExt_Difficulty>();
        if (extDiff == null)
        {
            return;
        }

        if (__result > 0f)
        {
            __result *= extDiff.moodImpactFactorPositive;
        }
        else
        {
            __result *= extDiff.moodImpactFactorNegative;
        }
    }
}