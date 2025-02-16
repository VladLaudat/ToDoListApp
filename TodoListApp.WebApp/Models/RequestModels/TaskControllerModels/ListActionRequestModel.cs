using System.ComponentModel.DataAnnotations;

namespace TodoListApp.WebApp.Models.RequestModels.TaskControllerModels;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public class ListActionRequestModel
{
    [Required]
    [Range(1, int.MaxValue)]
    public int Page { get; set; }
}
