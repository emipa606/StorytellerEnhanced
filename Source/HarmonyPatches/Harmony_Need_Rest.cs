using Harmony;
using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Verse;
using UnityEngine;

namespace StorytellerEnhanced
{

    [HarmonyPatch(typeof(Need_Rest))]
    [HarmonyPatch("RestFallFactor", PropertyMethod.Getter)]
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
