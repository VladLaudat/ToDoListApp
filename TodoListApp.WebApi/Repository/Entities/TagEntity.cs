using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
[Table("tag")]
public class TagEntity : BaseEntity
{
    [Column("description")]
    public string Description { get; set; } = string.Empty;

    public IList<TaskEntity>? Tasks { get; }
}
