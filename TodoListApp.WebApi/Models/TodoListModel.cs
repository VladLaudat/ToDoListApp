using System.ComponentModel.DataAnnotations.Schema;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Models;

public class TodoListModel : BaseModel
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public IList<TaskEntity>? Task { get; }
}
