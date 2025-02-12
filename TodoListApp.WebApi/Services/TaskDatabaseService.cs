using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Services;
public class TaskDatabaseService : BaseDatabaseService<TaskEntity, TaskDatabaseService>
{
    public TaskDatabaseService(TodoListDbContext dbContext, ILogger<TaskDatabaseService> logger)
        : base(dbContext, logger)
    {
    }
}
