using TodoListApp.WebApp.WebAPIServices.Helpers;

namespace TodoListApp.WebApp.WebAPIServices;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public class TaskWebApiService : GenericWebApiService<Models.Task, TaskWebApiService>
{
    public TaskWebApiService(IGenericServiceHelpers<Models.Task> helpers, HttpClient httpClient, ILogger<TaskWebApiService> logger)
        : base(helpers, httpClient, logger)
    {
    }
}
