using Il2CppPixelCrushers.DialogueSystem;

namespace SuzerainDataDumper.Serializers;

internal sealed class DialogueEntrySerializer : Serializer<DialogueEntry>
{
    public DialogueEntrySerializer(DialogueEntry obj) : base(obj)
    {
    }

    protected override JsonObjectBuilder ToJsonObjectBuilder()
    {
        return new JsonObjectBuilder(nameof(DialogueEntry))
            .AddProperty(nameof(DialogueEntry.ActorID), Object.ActorID)
            .AddProperty(nameof(DialogueEntry.conditionsString), Object.conditionsString)
            .AddProperty(nameof(DialogueEntry.ConversantID), Object.ConversantID)
            .AddProperty(nameof(DialogueEntry.conversationID), Object.conversationID)
            .AddProperty(nameof(DialogueEntry.fields),
                JsonObjectBuilder.FromIl2CppList(Object.fields, (obj) => new FieldSerializer(obj)))
            .AddProperty(nameof(DialogueEntry.id), Object.id)
             .AddProperty(nameof(DialogueEntry.outgoingLinks),
                JsonObjectBuilder.FromIl2CppList(Object.outgoingLinks,
                    (obj) => new LinkSerializer(obj)))
            .AddProperty(nameof(DialogueEntry.Title), Object.Title)
            .AddProperty(nameof(DialogueEntry.userScript), Object.userScript);
    }
}
