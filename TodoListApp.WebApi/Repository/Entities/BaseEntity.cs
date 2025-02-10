using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApi.Repository.Entities;

public abstract class BaseEntity
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
}
