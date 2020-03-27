using HarmonyLib;
using RimWorld;
using Verse;

namespace StorytellerEnhanced
{

    [HarmonyPatch(typeof(Thought))]
    [HarmonyPatch("MoodOffset")]
    public class Harmony_Thought_MoodOffset
    {

        public static void Postfix(ref float __result)
        {
            ModExt_Difficulty extDiff = Find.Storyteller.difficulty.GetModExtension<ModExt_Difficulty>();
            if (extDiff != null)
            {
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

    }

}
