
//using MGSC;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UnityEngine;

using HarmonyLib;
using MGSC;
using static MGSC.LimitsTooltip;

namespace OpenDoorWhenRunning
{
    [HarmonyPatch(typeof(PlayerInteractionSystem), nameof(PlayerInteractionSystem.CanInteractObstacles))]
    public static class ExamplePatch
    {
        public static void Postfix(Creatures creatures, Scenarios scenarios, MapObstacle contextObstacle, ref LimitsTooltip.LimitType limitType, ref bool __result)
        {
            if (creatures.Player.MovementState == CreatureMovementState.Run && contextObstacle.Door != null && limitType == LimitsTooltip.LimitType.RunNoObstacles)
            {
                __result = true;
            }
        }
    }
}
