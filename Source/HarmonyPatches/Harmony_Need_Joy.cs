using HarmonyLib;
using RimWorld;
using Verse;

namespace StorytellerEnhanced
{

    [HarmonyPatch(typeof(Need_Joy))]
    [HarmonyPatch("FallPerInterval", MethodType.Getter)]
    public class Harmony_Need_Joy_FallPerInterval
    {

        public static void Postfix(ref float __result)
        {
            ModExt_Difficulty extDiff = Find.Storyteller.difficulty.GetModExtension<ModExt_Difficulty>();
            if (extDiff != null)
            {
                __result *= extDiff.needJoyFallFactor;
            }
        }

    }

}
