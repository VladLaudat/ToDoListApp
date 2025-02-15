using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TodoListApp.WebApp.WebAPIServices.Models;

public class Task : BaseModel
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("createdDate")]
    public DateTime CreatedDate { get; set; }

    [JsonPropertyName("dueDate")]
    public DateTime DueDate { get; set; }

    [JsonPropertyName("statusId")]
    public int StatusId { get; set; }

    [JsonPropertyName("todoListId")]
    public int? TodoListId { get; set; }

    [JsonPropertyName("status")]
    public Status? Status { get; set; }

    [JsonPropertyName("todoList")]
    public TodoList? TodoList { get; set; }

    [JsonPropertyName("tags")]
    public IList<Tag>? Tags { get; }
}
