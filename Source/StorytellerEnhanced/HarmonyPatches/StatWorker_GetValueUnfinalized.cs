﻿using HarmonyLib;
using RimWorld;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(StatWorker), nameof(StatWorker.GetValueUnfinalized))]
public class StatWorker_GetValueUnfinalized
{
    public static void Postfix(ref float __result, StatDef ___stat)
    {
        if (___stat != StatDefOf.WorkSpeedGlobal)
        {
            return;
        }

        var extDiff = HarmonySetup.CurrentDifficultyDef?.GetModExtension<ModExt_Difficulty>();
        if (extDiff != null)
        {
            __result *= extDiff.workSpeedGlobalFactor;
        }
    }
}