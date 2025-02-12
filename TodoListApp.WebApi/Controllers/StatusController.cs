using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Controllers;

public class StatusController : BaseController<StatusEntity, StatusController>
{
    public StatusController(IBaseDatabaseService<StatusEntity> statusDatabaseService, ILogger<StatusController> logger)
        : base(statusDatabaseService, logger)
    {
    }
}
