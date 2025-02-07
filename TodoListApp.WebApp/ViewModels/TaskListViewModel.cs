using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.WebApp.ViewModels;

public class TaskListViewModel
{
    public IList<TaskViewModel> Tasks { get; set; }

    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }
}
