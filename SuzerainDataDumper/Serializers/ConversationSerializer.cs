using Il2CppPixelCrushers.DialogueSystem;

namespace SuzerainDataDumper.Serializers;

internal sealed class ConversationSerializer : Serializer<Conversation>
{
    public ConversationSerializer(Conversation obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(Conversation))
            .AddProperty(nameof(Conversation.dialogueEntries),
                JsonObjectBuilder.FromIl2CppList(Object.dialogueEntries,
                    (obj) => new DialogueEntrySerializer(obj)))
            .AddProperty(nameof(Conversation.id), Object.id)
            .AddProperty(nameof(Conversation.Title), Object.Title);
    }
}
