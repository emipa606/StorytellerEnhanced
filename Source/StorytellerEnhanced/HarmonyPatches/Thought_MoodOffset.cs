using HarmonyLib;
using RimWorld;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Thought), nameof(Thought.MoodOffset))]
public class Thought_MoodOffset
{
    public static void Postfix(ref float __result)
    {
        var extDiff = HarmonySetup.CurrentDifficultyDefExtension;
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