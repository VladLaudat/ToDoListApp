using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[Table("tag")]
public class TagEntity : BaseEntity
{
    [Column("description")]
    public string Description { get; set; } = string.Empty;

    public IList<TaskEntity>? Tasks { get; }
}
