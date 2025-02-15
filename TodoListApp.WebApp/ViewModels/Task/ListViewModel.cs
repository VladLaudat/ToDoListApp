using System.ComponentModel.DataAnnotations.Schema;
using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.ViewModels.Task;

public class ListViewModel
{
    public IList<WebAPIServices.Models.Task> Tasks { get; set; }

    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }
}
