using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Verse;

namespace StorytellerEnhanced
{

    [StaticConstructorOnStartup]
    class Harmony
    {

        static Harmony()
        {
            HarmonyInstance harmony = HarmonyInstance.Create("rimworld.lanilor.storytellerenhanced");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }

    }

}
