using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Controllers;
public class CommentController : BaseController<CommentEntity, CommentController>
{
    public CommentController(IBaseDatabaseService<CommentEntity> commentDatabaseService, ILogger<CommentController> logger)
        : base(commentDatabaseService, logger)
    {
    }
}
