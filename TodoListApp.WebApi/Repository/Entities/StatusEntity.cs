using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[Table("task_status")]
public class StatusEntity : BaseEntity
{
    [Column("description")]
    public string Description { get; set; } = string.Empty;

    [Column("is_active")]
    public bool IsActive { get; set; }
}
