using System.Text.Json.Serialization;

namespace TodoListApp.WebApp.Models.JsonDeserializationModels;

public class TaskJsonModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }

    [JsonPropertyName("dueDate")]
    public DateTime? DueDate { get; set; }
}
