using Il2CppPixelCrushers.DialogueSystem;
using MelonLoader;
using MelonLoader.Utils;
using SuzerainDataDumper.Serializers;

namespace SuzerainDataDumper;

internal static class ConversationsDumper
{
    public static void DumpSordlandConversations()
    {
        Melon<Core>.Logger.Msg("Dumping Sordland conversations...");
        DumpConversations("Sordland");
    }

    public static void DumpRiziaConversations()
    {
        Melon<Core>.Logger.Msg("Dumping Rizia conversations...");
        DumpConversations("Rizia");
    }

    private static void DumpConversations(string prefix)
    {
        JsonObjectBuilder builder = new($"<conversations {prefix}>");

        DialogueDatabase db = DialogueManager.MasterDatabase;
        List<Conversation> conversations = [];
        foreach (Conversation c in db.conversations)
        {
            if (c.Title.StartsWith(prefix, StringComparison.Ordinal))
            {
                conversations.Add(c);
            }
        }

        _ = builder.AddProperty("conversations",
                JsonObjectBuilder.FromList(conversations,
                    (obj) => new ConversationSerializer(obj)));

        string outputPath = Path.Combine(
            MelonEnvironment.MelonLoaderLogsDirectory,
            $"SuzerainDataDumper.conversations_{prefix}.json");

        File.WriteAllText(outputPath, builder.ToString());
        Melon<Core>.Logger.Msg($"Conversations dumped to '{outputPath}'.");
    }
}
