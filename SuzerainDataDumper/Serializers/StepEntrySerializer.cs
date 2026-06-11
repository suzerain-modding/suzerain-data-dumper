using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class StepEntrySerializer : Serializer<StepEntry>
{
    public StepEntrySerializer(StepEntry obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(StepEntry))
            .AddProperty(nameof(StepEntry.Fragments),
                JsonObjectBuilder.FromIl2CppList(Object.Fragments))
            .AddProperty(nameof(StepEntry.OnStepStartInstruction), Object.OnStepStartInstruction);
    }
}
