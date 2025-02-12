using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Services;

public class TodoListDatabaseService : BaseDatabaseService<TodoListEntity, TodoListDatabaseService>
{
    public TodoListDatabaseService(TodoListDbContext dbContext, ILogger<TodoListDatabaseService> logger)
        : base(dbContext, logger)
    {
    }
}
