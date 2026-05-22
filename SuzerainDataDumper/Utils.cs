using Il2CppPixelCrushers.DialogueSystem;

namespace SuzerainDataDumper;

internal static class Utils
{
    public static string ConditionPriorityToString(ConditionPriority priority)
    {
        return priority switch
        {
            ConditionPriority.Low => "Low",
            ConditionPriority.BelowNormal => "BelowNormal",
            ConditionPriority.Normal => "Normal",
            ConditionPriority.AboveNormal => "AboveNormal",
            ConditionPriority.High => "High",
            _ => "<unknown ConditionPriority>",
        };
    }
}
