using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class ConditionalInstructionDataSerializer : Serializer<ConditionalInstructionData>
{
    public ConditionalInstructionDataSerializer(ConditionalInstructionData obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(ConditionalInstructionData))
            .AddProperty(nameof(ConditionalInstructionData.AppBundleProperties),
                new AppBundlePropertiesSerializer(Object.AppBundleProperties))
            .AddProperty(nameof(ConditionalInstructionData.ConditionalInstructionProperties),
                new ConditionalInstructionPropertiesSerializer(
                    Object.ConditionalInstructionProperties))
            .AddProperty(nameof(ConditionalInstructionData.NameInDatabase), Object.NameInDatabase)
            .AddProperty(nameof(ConditionalInstructionData.Path), Object.Path);
    }
}
