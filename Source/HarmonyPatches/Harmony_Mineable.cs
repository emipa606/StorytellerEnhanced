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

    [HarmonyPatch(typeof(Mineable))]
    [HarmonyPatch("TrySpawnYield")]
    public class Harmony_Mineable_TrySpawnYield
    {

        // TODO: Improve into a transpiler
        public static bool Prefix(Mineable __instance, Map map, float yieldChance, bool moteOnWaste, Pawn pawn, float ___yieldPct)
        {
            ModExt_Difficulty extDiff = Find.Storyteller.difficulty.GetModExtension<ModExt_Difficulty>();
            if (extDiff == null || extDiff.miningYieldFactor == 1f)
            {
                return true;
            }
			if (__instance.def.building.mineableThing != null)
			{
                float mineableDropChance = __instance.def.building.mineableDropChance;
                int mineableYield = __instance.def.building.mineableYield;
                if (mineableDropChance != 1f)
                {
                    mineableDropChance *= extDiff.miningYieldFactor;
                }
                else
                {
                    mineableYield = GenMath.RoundRandom(extDiff.miningYieldFactor * mineableYield);
                }
				if (Rand.Value <= mineableDropChance)
				{
					if (__instance.def.building.mineableYieldWasteable)
					{
						mineableYield = Mathf.Max(1, GenMath.RoundRandom((float)mineableYield * ___yieldPct));
					}
					Thing thing = ThingMaker.MakeThing(__instance.def.building.mineableThing);
					thing.stackCount = mineableYield;
					GenSpawn.Spawn(thing, __instance.Position, map);
					if (pawn == null || !pawn.IsColonist)
					{
						if (thing.def.EverHaulable && !thing.def.designateHaulable)
						{
							thing.SetForbidden(true);
						}
					}
				}
			}
            return false;
		}

    }

}
