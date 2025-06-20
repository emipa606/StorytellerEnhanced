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

    private static readonly FieldInfo defFieldInfo = AccessTools.Field(typeof(Storyteller), "def");


    static HarmonySetup()
    {
        var harmony = new Harmony("rimworld.neptimus7.storytellerenhanced");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }

    public static DifficultyDef CurrentDifficultyDef
    {
        get
        {
            if (currentDifficultyDef != null &&
                (lastUpdated == 0 || lastUpdated < GenTicks.TicksGame - GenTicks.TickRareInterval))
            {
                return currentDifficultyDef;
            }

            lastUpdated = GenTicks.TicksGame;
            var difficultyDef = defFieldInfo.GetValue(Find.Storyteller);
            if (difficultyDef is DifficultyDef difficulty)
            {
                currentDifficultyDef = difficulty;
            }

            return currentDifficultyDef;
        }
    }
}