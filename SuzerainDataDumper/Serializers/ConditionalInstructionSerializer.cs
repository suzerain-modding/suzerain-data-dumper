using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class ConditionalInstructionSerializer : Serializer<ConditionalInstruction>
{
    public ConditionalInstructionSerializer(ConditionalInstruction obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(ConditionalInstruction))
            .AddProperty(nameof(ConditionalInstruction.Condition), Object.Condition)
            .AddProperty(nameof(ConditionalInstruction.Instruction), Object.Instruction);
    }
}
