namespace TodoListApp.WebApp.WebAPIServices.Models;

public class Status : BaseModel
{
    public string Description { get; set; } = string.Empty;

    public bool IsActive { get; set; }
}
