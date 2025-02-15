using System.Text.Json.Serialization;

namespace TodoListApp.WebApp.WebAPIServices.Models;

public class TodoList : BaseModel
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("tasks")]
    public IList<Task>? Tasks { get; }
}
