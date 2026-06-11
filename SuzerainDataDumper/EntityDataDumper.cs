using Il2Cpp;
using MelonLoader;
using MelonLoader.Utils;
using SuzerainDataDumper.Serializers;

namespace SuzerainDataDumper;

internal static class EntityDataDumper
{
    public static void Dump()
    {
        Melon<Core>.Logger.Msg("Dumping entity data...");

        JsonObjectBuilder builder = new("<entity data>");

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

        JsonObjectBuilder conditionalInstructionsArrayBuilder = JsonObjectBuilder.FromIl2CppList(
            EntityDataManager.conditionalInstructionData,
            (obj) => new ConditionalInstructionDataSerializer(obj));
        _ = builder.AddProperty(nameof(EntityDataManager.conditionalInstructionData),
                conditionalInstructionsArrayBuilder);

        JsonObjectBuilder gameFlowDataArrayBuilder = JsonObjectBuilder.FromIl2CppList(
            EntityDataManager.GameFlowData,
            (obj) => new GameFlowDataSerializer(obj));
        _ = builder.AddProperty(nameof(EntityDataManager.GameFlowData), gameFlowDataArrayBuilder);

        JsonObjectBuilder newsArrayBuilder = JsonObjectBuilder.FromIl2CppList(
            EntityDataManager.NewsData,
            (obj) => new NewsDataSerializer(obj));
        _ = builder.AddProperty(nameof(EntityDataManager.NewsData), newsArrayBuilder);

        string outputPath = Path.Combine(
            MelonEnvironment.MelonLoaderLogsDirectory,
            "SuzerainDataDumper.entity_data.json");

        File.WriteAllText(outputPath, builder.ToString());
        Melon<Core>.Logger.Msg($"Entity data dumped to '{outputPath}'.");
    }
}
