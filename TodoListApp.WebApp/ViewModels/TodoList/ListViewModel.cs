using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.ViewModels.TodoList;

public class ListViewModel
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Need the setter")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "Need the suppression")]
    public IList<WebAPIServices.Models.TodoList>? TodoLists { get; set; }

    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }
}
