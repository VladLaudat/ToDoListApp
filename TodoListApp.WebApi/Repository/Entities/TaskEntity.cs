using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
[Table("task")]
public class TaskEntity : BaseEntity
{
    [Column("title")]
    public string Title { get; set; } = string.Empty;

    [Column("description")]
    public string Description { get; set; } = string.Empty;

    [Column("created_date", TypeName = "date")]
    public DateTime CreatedDate { get; set; }

    [Column("due_date", TypeName = "date")]
    public DateTime DueDate { get; set; }

    [Column("task_status_id")]
    [ForeignKey(nameof(Status))]
    public int StatusId { get; set; }

    [Column("todolist_id")]
    [ForeignKey(nameof(TodoList))]
    public int? TodoListId { get; set; }

    public StatusEntity? Status { get; set; }

    public TodoListEntity? TodoList { get; set; }

    public IList<TagEntity>? Tags { get; }
}
