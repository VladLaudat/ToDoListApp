using System.ComponentModel.DataAnnotations;

namespace TodoListApp.WebApi.Models;

public class TodoListModel
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }
}
