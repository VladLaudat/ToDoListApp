using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TodoListApp.WebApi.Repository.Entities;

[Table("todo_list")]
public class TodoListEntity : BaseEntity
{
    [Column("title")]
    public string Title { get; set; } = string.Empty;

    [Column("description")]
    public string Description { get; set; } = string.Empty;

    public IList<TaskEntity>? Tasks { get; }
}
