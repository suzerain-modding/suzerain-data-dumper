using Il2CppPixelCrushers.DialogueSystem;

namespace SuzerainDataDumper.Serializers;

internal sealed class LinkSerializer : Serializer<Link>
{
    public LinkSerializer(Link obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(Link))
            .AddProperty(nameof(Link.destinationConversationID), Object.destinationConversationID)
            .AddProperty(nameof(Link.destinationDialogueID), Object.destinationDialogueID)
            .AddProperty(nameof(Link.isConnector), Object.isConnector)
            .AddProperty(nameof(Link.originConversationID), Object.originConversationID)
            .AddProperty(nameof(Link.originDialogueID), Object.originDialogueID)
            .AddProperty(nameof(Link.priority), Utils.ConditionPriorityToString(Object.priority));
    }
}
