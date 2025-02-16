using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(ExtraTerror.Core), "ExtraTerror", "1.0.0", "NightPotato", null)]
[assembly: MelonGame("TeamMonumental", "Subterror")]
namespace ExtraTerror;

public class Core : MelonMod
{
    private MelonPreferences_Category extraTerrorCategory;
    public MelonPreferences_Entry<int> maxPlayerCount;

    public override void OnInitializeMelon()
    {
        // Mod Configuration File
        extraTerrorCategory = MelonPreferences.CreateCategory("ExtraTerror");
        extraTerrorCategory.SetFilePath("UserData/ExtraTerror.cfg");
        maxPlayerCount = extraTerrorCategory.CreateEntry<int>("MaxPlayerCount", 8);
        extraTerrorCategory.SaveToFile();

        // Get Count of Loaded Players
        var foundSouls = GameObject.FindObjectsOfType<TeamMonumental.Soul>();
        int soulsCount = foundSouls.Length;

        // Logging to See our Mod has Started
        LoggerInstance.Msg("Initialized.");
    }

}