using System.Text.Json.Serialization;

namespace TodoListApp.WebApp.WebAPIServices.Models;

public class Tag : BaseModel
{
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("tasks")]
    public IList<Task>? Tasks { get; }
}
