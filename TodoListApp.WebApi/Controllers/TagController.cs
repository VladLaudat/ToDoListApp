using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Controllers;

public class TagController : BaseController<TagEntity, TagController>
{
    public TagController(IBaseDatabaseService<TagEntity> tagDatabaseService, ILogger<TagController> logger)
        : base(tagDatabaseService, logger)
    {
    }
}
