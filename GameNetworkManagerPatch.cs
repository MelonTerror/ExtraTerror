using HarmonyLib;
using TeamMonumental;
using System.Reflection;
using HarmonyLib.Tools;
using MelonLoader;

namespace ExtraTerror
{
    [HarmonyPatch(typeof(GameNetworkManager), "Awake")]
    class GameNetworkManagerPatch
    {
        private static void Postfix()
        {

            MelonLogger.Msg("Starting Patch of GameNetworkManager....");

            Type gameManager = typeof(GameNetworkManager);
            FieldInfo playerCount = gameManager.GetField("MAX_PLAYER_COUNT");
            playerCount.SetValue(playerCount, MelonPreferences.GetEntryValue<int>("ExtraTerror", "MaxPlayerCount"));

            MelonLogger.Msg("Successfully Patched GameNetworkManager!!!");
        }

    }
}