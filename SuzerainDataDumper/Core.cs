using MelonLoader;
using UnityEngine;
using UnityEngine.InputSystem;

[assembly: MelonInfo(typeof(SuzerainDataDumper.Core), "Suzerain Data Dumper", "0.1.0", "Fluffyalien1422", null)]
[assembly: MelonGame("Torpor Games", "Suzerain")]

namespace SuzerainDataDumper;

internal sealed class Core : MelonMod
{
    public bool FirstKeybindPressed
    {
        get; set;
    }

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

        if (kb.ctrlKey.isPressed && kb.shiftKey.isPressed && kb.eKey.wasPressedThisFrame)
        {
            FirstKeybindPressed = !FirstKeybindPressed;
            return;
        }

        if (!FirstKeybindPressed)
        {
            return;
        }
        if (kb.ctrlKey.isPressed && kb.eKey.wasPressedThisFrame)
        {
            EntityDataDumper.Dump();
        }
        else if (kb.ctrlKey.isPressed && kb.sKey.wasPressedThisFrame)
        {
            ConversationsDumper.DumpSordlandConversations();
        }
        else if (kb.ctrlKey.isPressed && kb.rKey.wasPressedThisFrame)
        {
            ConversationsDumper.DumpRiziaConversations();
        }
        else
        {
            return;
        }
        FirstKeybindPressed = false;
    }

    public override void OnGUI()
    {
        if (!FirstKeybindPressed)
        {
            return;
        }

        int overlayWidth = 200;
        GUILayout.BeginArea(new Rect(10, 10, overlayWidth, overlayWidth));
        GUILayout.BeginVertical(GUI.skin.box);

        GUILayout.Label("Suzerain Data Dumper");
        GUILayout.Label("Ctrl+Shift+E pressed. Waiting for second keybind.");
        GUILayout.Label("Ctrl+Shift+E again to cancel.");
        GUILayout.Label("Ctrl+E to dump entity data.");
        GUILayout.Label("Ctrl+S to dump Sordland conversations.");
        GUILayout.Label("Ctrl+R to dump Rizia conversations.");

        GUILayout.EndVertical();
        GUILayout.EndArea();
    }
}
