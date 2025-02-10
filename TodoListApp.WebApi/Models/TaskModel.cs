using System.ComponentModel.DataAnnotations.Schema;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Models;

public class TaskModel : BaseModel
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; }

    public DateTime DueDate { get; set; }

    public int StatusId { get; set; }

    public int? TodoListId { get; set; }

    public StatusEntity? Status { get; set; }

    public TodoListEntity? TodoList { get; set; }

    public IList<TagEntity>? Tags { get; set; }
}
