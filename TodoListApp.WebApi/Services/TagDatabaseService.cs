using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Services;

public class TagDatabaseService : BaseDatabaseService<TagEntity, TagDatabaseService>
{
    public TagDatabaseService(TodoListDbContext dbContext, ILogger<TagDatabaseService> logger)
        : base(dbContext, logger)
    {
    }
}
