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

    [HarmonyPatch(typeof(Thing))]
    [HarmonyPatch("ButcherProducts")]
    public class Harmony_Thing_ButcherProducts
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

    [HarmonyPatch(typeof(Thing))]
    [HarmonyPatch("TakeDamage")]
    public class Harmony_Thing_TakeDamage
    {

        public static void Prefix(Thing __instance, ref DamageInfo dinfo)
        {
            ModExt_Difficulty extDiff = Find.Storyteller.difficulty.GetModExtension<ModExt_Difficulty>();
            if (extDiff != null)
            {
                if (__instance.Faction == Faction.OfPlayer)
                {
                    dinfo.SetAmount(dinfo.Amount * extDiff.damageFactorOnPlayer);
                }
                else if (__instance.Faction != null)
                {
                    dinfo.SetAmount(dinfo.Amount * extDiff.damageFactorOnOther);
                }
            }
        }

    }

}
