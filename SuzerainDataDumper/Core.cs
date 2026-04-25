using MelonLoader;
using UnityEngine.InputSystem;

[assembly: MelonInfo(typeof(SuzerainDataDumper.Core), "Suzerain Data Dumper", "1.0.0", "Fluffyalien", null)]
[assembly: MelonGame("Torpor Games", "Suzerain")]

namespace SuzerainDataDumper;

internal sealed class Core : MelonMod
{
    public override void OnInitializeMelon()
    {
        LoggerInstance.Msg("Initialized.");
    }

    public override void OnUpdate()
    {
        Keyboard kb = Keyboard.current;
        if (kb == null)
        {
            return;
        }

        if (kb.ctrlKey.isPressed && kb.shiftKey.isPressed && kb.dKey.wasPressedThisFrame)
        {
            DumpData();
        }
    }

    public void DumpData()
    {
        LoggerInstance.Msg("Dumping data...");
        EntityDataDumper.Dump();
        LoggerInstance.Msg("Done.");
    }
}