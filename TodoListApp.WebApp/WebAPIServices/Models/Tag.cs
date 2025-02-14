namespace TodoListApp.WebApp.WebAPIServices.Models;

public class Tag : BaseModel
{
    public string Description { get; set; } = string.Empty;

    public IList<Task>? Tasks { get; }
}
