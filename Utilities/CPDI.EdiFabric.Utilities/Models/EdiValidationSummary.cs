namespace CPDI.EdiFabric.Utilities.Models
{
    public record EdiValidationSummary(
        bool IsValid,
        int ItemsCount,
        string? SelectedTemplateFullName,
        string? SelectedTemplateAssembly,
        IReadOnlyList<EdiValidationItemResult> Items,
        IReadOnlyList<string> Messages // general messages/warnings
    );
}
