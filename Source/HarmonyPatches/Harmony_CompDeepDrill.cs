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

    [HarmonyPatch(typeof(CompDeepDrill))]
    [HarmonyPatch("TryProducePortion")]
    public class Harmony_CompDeepDrill_TryProducePortion
    {

        public static void Prefix(ref float yieldPct)
        {
            ModExt_Difficulty extDiff = Find.Storyteller.difficulty.GetModExtension<ModExt_Difficulty>();
            if (extDiff != null)
            {
                yieldPct *= extDiff.miningYieldFactor;
            }
        }

    }

}
