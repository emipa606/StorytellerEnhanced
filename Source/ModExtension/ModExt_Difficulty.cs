using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace StorytellerEnhanced
{

    public class ModExt_Difficulty : DefModExtension
    {

        public float workSpeedGlobalFactor = 1f;

        public float butcherProductFactor = 1f;
        public float miningYieldFactor = 1f;

        public float moodImpactFactorNegative = 1f;
        public float moodImpactFactorPositive = 1f;

        public float needRestFallFactor = 1f;
        public float needJoyFallFactor = 1f;

        public float damageFactorOnPlayer = 1f;
        public float damageFactorOnOther = 1f;

    }
    
}
