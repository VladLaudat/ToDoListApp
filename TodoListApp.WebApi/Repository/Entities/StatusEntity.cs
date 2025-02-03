using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[Table("task_status")]
public class StatusEntity
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("is_active")]
    public bool IsActive { get; set; }
}
