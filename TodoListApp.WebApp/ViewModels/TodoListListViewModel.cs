namespace TodoListApp.WebApp.ViewModels;

public class TodoListListViewModel
{
    public IList<TodoListViewModel> TodoLists { get; set; }

    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }
}
