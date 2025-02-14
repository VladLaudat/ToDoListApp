using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApp.WebAPIServices.Models;

public class Task : BaseModel
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; }

    public DateTime DueDate { get; set; }

    public int StatusId { get; set; }

    public int? TodoListId { get; set; }

    public Status? Status { get; set; }

    public TodoList? TodoList { get; set; }

    public IList<Tag>? Tags { get; }
}
