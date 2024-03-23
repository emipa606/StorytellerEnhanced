using System.Reflection;
using HarmonyLib;
using RimWorld;
using Verse;

namespace StorytellerEnhanced;

[StaticConstructorOnStartup]
internal class HarmonySetup
{
    private static DifficultyDef currentDifficultyDef;

    private static int LastUpdated;


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
                (LastUpdated == 0 || LastUpdated < GenTicks.TicksGame - GenTicks.TickRareInterval))
            {
                return currentDifficultyDef;
            }

            LastUpdated = GenTicks.TicksGame;
            var difficultyDef = Traverse.Create(Find.Storyteller).Field("def").GetValue();
            if (difficultyDef is DifficultyDef difficulty)
            {
                currentDifficultyDef = difficulty;
            }

            return currentDifficultyDef;
        }
    }
}