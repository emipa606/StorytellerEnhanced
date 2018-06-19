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

    [HarmonyPatch(typeof(Pawn))]
    [HarmonyPatch("ButcherProducts")]
    public class Harmony_Pawn_ButcherProducts
    {

        public static void Prefix(ref float efficiency)
        {
            ModExt_Difficulty extDiff = Find.Storyteller.difficulty.GetModExtension<ModExt_Difficulty>();
            if (extDiff != null)
            {
                efficiency *= extDiff.butcherProductFactor;
            }
        }

    }

}
