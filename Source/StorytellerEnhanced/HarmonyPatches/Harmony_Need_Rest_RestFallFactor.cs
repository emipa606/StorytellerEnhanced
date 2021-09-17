using HarmonyLib;
using RimWorld;

namespace StorytellerEnhanced
{
    [HarmonyPatch(typeof(Need_Rest))]
    [HarmonyPatch("RestFallFactor", MethodType.Getter)]
    public class Harmony_Need_Rest_RestFallFactor
    {
        public static void Postfix(ref float __result)
        {
            var extDiff = HarmonySetup.CurrentDifficultyDef?.GetModExtension<ModExt_Difficulty>();
            if (extDiff != null)
            {
                __result *= extDiff.needRestFallFactor;
            }
        }
    }
}