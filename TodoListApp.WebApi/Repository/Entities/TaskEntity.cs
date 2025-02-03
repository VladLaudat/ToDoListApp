using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[Table("task")]
public class TaskEntity
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("title")]
    public string Title { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("created_date", TypeName = "date")]
    public DateTime CreatedDate { get; set; }

    [Column("due_date", TypeName = "date")]
    public DateTime DueDate { get; set; }

    [Column("task_status_id")]
    [ForeignKey(nameof(Status))]
    public int StatusId { get; set; }

    [Column("todolist_id")]
    [ForeignKey(nameof(TodoList))]
    public int TodoListId { get; set; }

    public StatusEntity Status { get; set; }

    public TodoListEntity TodoList { get; set; }

    public IList<TagEntity> Tags { get; set; }
}
