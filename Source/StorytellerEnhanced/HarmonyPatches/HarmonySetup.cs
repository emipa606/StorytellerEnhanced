using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace StorytellerEnhanced;

[StaticConstructorOnStartup]
internal class HarmonySetup
{
    private static DifficultyDef currentDifficultyDef;

    private static int lastUpdated;

    static HarmonySetup()
    {
        var harmony = new Harmony("rimworld.neptimus7.storytellerenhanced");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }

    public static ModExt_Difficulty CurrentDifficultyDefExtension
    {
        get
        {
            if (currentDifficultyDef != null &&
                (lastUpdated == 0 || lastUpdated > GenTicks.TicksGame - GenTicks.TickRareInterval))
            {
                return field;
            }
            lastUpdated = GenTicks.TicksGame;
            currentDifficultyDef = Find.Storyteller.difficultyDef;
            field = currentDifficultyDef?.GetModExtension<ModExt_Difficulty>();
            return field;
        }
    }
}