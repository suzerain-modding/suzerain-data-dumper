using Il2Cpp;
using MelonLoader;
using MelonLoader.Utils;
using SuzerainDataDumper.Serializers;

namespace SuzerainDataDumper;

internal static class EntityDataDumper
{
    public static void Dump()
    {
        Melon<Core>.Logger.Msg("Dumping EntityDataManager...");

        JsonObjectBuilder builder = new(nameof(EntityDataManager));

        List<ConversationData> conversationsData = Utils.ListFromIl2CppList(
            EntityDataManager.AllConversationsData);
        JsonObjectBuilder conversationsArrayBuilder = JsonObjectBuilder.FromList(
            conversationsData,
            (obj) => new ConversationDataSerializer(obj));
        _ = builder.AddProperty(nameof(EntityDataManager.AllConversationsData),
                conversationsArrayBuilder);

        string outputPath = Path.Combine(
            MelonEnvironment.MelonLoaderLogsDirectory,
            "SuzerainDataDumper_EntityDataManager.json");

        File.WriteAllText(outputPath, builder.ToString());
        Melon<Core>.Logger.Msg($"EntityDataManager dumped to '{outputPath}'.");
    }
}
