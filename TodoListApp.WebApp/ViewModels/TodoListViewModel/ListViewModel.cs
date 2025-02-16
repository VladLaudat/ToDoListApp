using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.ViewModels.TodoListViewModel;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public class ListViewModel
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Need the setter")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "Need the suppression")]
    public IList<TodoList>? TodoLists { get; set; }

    public int CurrentPage { get; set; }

    public int TotalPages { get; set; }
}
