using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApp.WebAPIServices.Models;

public class Comment : BaseModel
{
    public string Text { get; set; } = string.Empty;

    public int TaskId { get; set; }

    public Task? Task { get; set; }
}
