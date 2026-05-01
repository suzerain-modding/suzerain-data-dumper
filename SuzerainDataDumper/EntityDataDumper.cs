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

        JsonObjectBuilder billsArrayBuilder = JsonObjectBuilder.FromIl2CppList(
            EntityDataManager.AllBillsData,
            (obj) => new BillDataSerializer(obj));
        _ = builder.AddProperty(nameof(EntityDataManager.AllBillsData), billsArrayBuilder);

        JsonObjectBuilder conversationsArrayBuilder = JsonObjectBuilder.FromIl2CppList(
            EntityDataManager.AllConversationsData,
            (obj) => new ConversationDataSerializer(obj));
        _ = builder.AddProperty(nameof(EntityDataManager.AllConversationsData),
                conversationsArrayBuilder);

        JsonObjectBuilder decisionsArrayBuilder = JsonObjectBuilder.FromIl2CppList(
            EntityDataManager.AllDecisionsData,
            (obj) => new DecisionDataSerializer(obj));
        _ = builder.AddProperty(nameof(EntityDataManager.AllDecisionsData),
                decisionsArrayBuilder);

        string outputPath = Path.Combine(
            MelonEnvironment.MelonLoaderLogsDirectory,
            "SuzerainDataDumper_EntityDataManager.json");

        File.WriteAllText(outputPath, builder.ToString());
        Melon<Core>.Logger.Msg($"EntityDataManager dumped to '{outputPath}'.");
    }
}
