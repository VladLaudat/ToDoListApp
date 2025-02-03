using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[Table("comment")]
public class CommentEntity
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("comment")]
    public string Comment { get; set; }

    [Column("task_id")]
    [ForeignKey(nameof(Task))]
    public int TaskId { get; set; }

    public TaskEntity Task { get; set; }
}
