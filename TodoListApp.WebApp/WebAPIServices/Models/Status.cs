using System.Text.Json.Serialization;

namespace TodoListApp.WebApp.WebAPIServices.Models;

public class Status : BaseModel
{
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("isActive")]
    public bool IsActive { get; set; }
}
