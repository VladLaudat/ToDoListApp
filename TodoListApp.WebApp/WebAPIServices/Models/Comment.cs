using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TodoListApp.WebApp.WebAPIServices.Models;

public class Comment : BaseModel
{
    [JsonPropertyName("text")]
    public string Text { get; set; } = string.Empty;

    [JsonPropertyName("taskId")]
    public int TaskId { get; set; }

    [JsonPropertyName("task")]
    public Task? Task { get; set; }
}
