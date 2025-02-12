using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Controllers;
public class TaskController : BaseController<TaskEntity, TaskController>
{
    public TaskController(IBaseDatabaseService<TaskEntity> taskDatabaseService, ILogger<TaskController> logger)
        : base(taskDatabaseService, logger)
    {
    }
}
