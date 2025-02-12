using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Services;

public class StatusDatabaseService : BaseDatabaseService<StatusEntity, StatusDatabaseService>
{
    public StatusDatabaseService(TodoListDbContext dbContext, ILogger<StatusDatabaseService> logger)
        : base(dbContext, logger)
    {
    }
}
