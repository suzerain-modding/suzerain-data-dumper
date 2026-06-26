using Il2CppPixelCrushers.DialogueSystem;
using MelonLoader;
using MelonLoader.Utils;

namespace SuzerainDataDumper;

internal static class ActorsDumper
{
    public static void DumpActorNames()
    {
        Melon<Core>.Logger.Msg("Dumping actor names...");

        JsonObjectBuilder builder = new("<actor names>");

        DialogueDatabase db = DialogueManager.MasterDatabase;
        List<string> actorNames = [];
        foreach (Actor a in db.actors)
        {
            actorNames.Add(a.Name);
        }

        _ = builder.AddProperty("actorNames", JsonObjectBuilder.FromList(actorNames));

        string outputPath = Path.Combine(
            MelonEnvironment.MelonLoaderLogsDirectory,
            "SuzerainDataDumper.actor_names.json");

        File.WriteAllText(outputPath, builder.ToString());
        Melon<Core>.Logger.Msg($"Actor names dumped to '{outputPath}'.");
    }
}
