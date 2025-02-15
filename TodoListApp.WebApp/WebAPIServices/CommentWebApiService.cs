using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.WebAPIServices;

public class CommentWebApiService : GenericWebApiService<Comment, CommentWebApiService>
{
    public CommentWebApiService(IGenericServiceHelpers<Comment> helpers, HttpClient httpClient, ILogger<CommentWebApiService> logger)
        : base(helpers, httpClient, logger)
    {
    }
}
