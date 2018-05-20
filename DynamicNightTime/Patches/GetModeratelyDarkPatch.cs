﻿using TwilightShards.Stardew.Common;

namespace DynamicNightTime.Patches
{
    class GettingModeratlyDarkPatch
    {
        public static void Postfix(ref int __result)
        {
            SDVTime calcTime = DynamicNightTime.GetSunset();
            calcTime.ClampToTenMinutes();

            __result = calcTime.ReturnIntTime();
        }
    }
}
