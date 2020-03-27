using HarmonyLib;
using System.Reflection;
using Verse;

namespace StorytellerEnhanced
{

    [StaticConstructorOnStartup]
    class HarmonySetup
    {

        static HarmonySetup()
        {
            var harmony = new Harmony("rimworld.neptimus7.storytellerenhanced");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

    }

}
