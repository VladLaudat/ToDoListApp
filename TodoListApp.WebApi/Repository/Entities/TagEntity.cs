using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[Table("tag")]
public class TagEntity
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("description")]
    public string Description { get; set; }

    public IList<TaskEntity> Tasks { get; set; }
}
