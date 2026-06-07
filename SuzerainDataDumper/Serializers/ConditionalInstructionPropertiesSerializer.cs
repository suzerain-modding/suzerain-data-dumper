using Il2Cpp;

namespace SuzerainDataDumper.Serializers;

internal sealed class ConditionalInstructionPropertiesSerializer : Serializer<ConditionalInstructionProperties>
{
    public ConditionalInstructionPropertiesSerializer(ConditionalInstructionProperties obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(ConditionalInstructionProperties))
            .AddProperty(nameof(ConditionalInstructionProperties.CheckOnStepNo), Object.CheckOnStepNo)
            .AddProperty(nameof(ConditionalInstructionProperties.CheckOnTurnNo), Object.CheckOnTurnNo)
            .AddProperty(nameof(ConditionalInstructionProperties.CheckPerStep), Object.CheckPerStep)
            .AddProperty(nameof(ConditionalInstructionProperties.CheckPerStoryFragment), Object.CheckPerStoryFragment)
            .AddProperty(nameof(ConditionalInstructionProperties.CheckPerTurn), Object.CheckPerTurn)
            .AddProperty(nameof(ConditionalInstructionProperties.ConditionalInstructions),
                JsonObjectBuilder.FromIl2CppList(Object.ConditionalInstructions,
                    (obj) => new ConditionalInstructionSerializer(obj)))
            .AddProperty(nameof(ConditionalInstructionProperties.IsOneTime), Object.IsOneTime)
            .AddProperty(nameof(ConditionalInstructionProperties.Priority), Object.Priority);
    }
}
