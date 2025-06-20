using HarmonyLib;
using RimWorld;
using Verse;

namespace StorytellerEnhanced;

[HarmonyPatch(typeof(Thing), nameof(Thing.TakeDamage))]
public class Thing_TakeDamage
{
    public static void Prefix(Thing __instance, ref DamageInfo dinfo)
    {
        var extDiff = HarmonySetup.CurrentDifficultyDef?.GetModExtension<ModExt_Difficulty>();
        if (extDiff == null)
        {
            return;
        }

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