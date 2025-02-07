using System.Text.Json.Serialization;

namespace TodoListApp.WebApp.ViewModels;

public class TaskViewModel
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}
