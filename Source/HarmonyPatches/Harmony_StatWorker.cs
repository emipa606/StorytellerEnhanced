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

    [HarmonyPatch(typeof(StatWorker))]
    [HarmonyPatch("GetValueUnfinalized")]
    public class Harmony_StatWorker_GetValueUnfinalized
    {

        public static void Postfix(ref float __result, StatDef ___stat)
        {
            if (___stat != StatDefOf.WorkSpeedGlobal)
            {
                return;
            }
            ModExt_Difficulty extDiff = Find.Storyteller.difficulty.GetModExtension<ModExt_Difficulty>();
            if (extDiff != null)
            {
                __result *= extDiff.workSpeedGlobalFactor;
            }
        }

    }

}
