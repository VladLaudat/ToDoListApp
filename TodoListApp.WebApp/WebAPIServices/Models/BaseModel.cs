using System.Text.Json.Serialization;

namespace TodoListApp.WebApp.WebAPIServices.Models;

public class BaseModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
}
