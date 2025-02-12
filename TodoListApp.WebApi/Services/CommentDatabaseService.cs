using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Services;

public class CommentDatabaseService : BaseDatabaseService<CommentEntity, CommentDatabaseService>
{
    public CommentDatabaseService(TodoListDbContext dbContext, ILogger<CommentDatabaseService> logger)
        : base(dbContext, logger)
    {
    }
}
