using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Controllers;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public class TaskController : BaseController<TaskEntity, TaskController>
{
    public TaskController(IBaseDatabaseService<TaskEntity> taskDatabaseService, ILogger<TaskController> logger)
        : base(taskDatabaseService, logger)
    {
    }
}
