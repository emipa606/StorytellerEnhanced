using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace StorytellerEnhanced;

[StaticConstructorOnStartup]
internal class HarmonySetup
{
    private static DifficultyDef currentDifficultyDef;

    static HarmonySetup()
    {
        new Harmony("rimworld.neptimus7.storytellerenhanced").PatchAll(Assembly.GetExecutingAssembly());
    }

    public static ModExt_Difficulty CurrentDifficultyDefExtension
    {
        get
        {
            if (Find.Storyteller.difficultyDef == currentDifficultyDef)
            {
                return field;
            }

            currentDifficultyDef = Find.Storyteller.difficultyDef;
            field = currentDifficultyDef?.GetModExtension<ModExt_Difficulty>();
            return field;
        }
    }
}