using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

[Table("todo_list")]
public class TodoListEntity
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("title")]
    public string Title { get; set; }

    [Column("description")]
    public string Description { get; set; }
}
