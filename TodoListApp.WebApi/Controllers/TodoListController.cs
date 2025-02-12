using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Controllers;
public class TodoListController : BaseController<TodoListEntity, TodoListController>
{
    public TodoListController(IBaseDatabaseService<TodoListEntity> todoListDatabaseService, ILogger<TodoListController> logger)
        : base(todoListDatabaseService, logger)
    {
    }
}
