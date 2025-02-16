using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TodoListApp.WebApp.WebAPIServices.Models;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public class Task : BaseModel
{
    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("createdDate")]
    public DateTime CreatedDate { get; set; }

    [JsonPropertyName("dueDate")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
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
