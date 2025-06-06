using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
[Table("comment")]
public class CommentEntity : BaseEntity
{
    [Column("comment")]
    public string Comment { get; set; } = string.Empty;

    [Column("task_id")]
    [ForeignKey(nameof(Task))]
    public int TaskId { get; set; }

    public TaskEntity? Task { get; set; }
}
