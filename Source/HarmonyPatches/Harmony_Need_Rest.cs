using HarmonyLib;
using RimWorld;
using Verse;

namespace StorytellerEnhanced
{

    [HarmonyPatch(typeof(Need_Rest))]
    [HarmonyPatch("RestFallFactor", MethodType.Getter)]
    public class Harmony_Need_Rest_RestFallFactor
    {

        public static void Postfix(ref float __result)
        {
            ModExt_Difficulty extDiff = Find.Storyteller.difficulty.GetModExtension<ModExt_Difficulty>();
            if (extDiff != null)
            {
                __result *= extDiff.needRestFallFactor;
            }
        }

    }

}
