using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.WebAPIServices;

public class TagWebApiService : GenericWebApiService<Tag, TagWebApiService>
{
    public TagWebApiService(IGenericServiceHelpers<Tag> helpers, HttpClient httpClient, ILogger<TagWebApiService> logger)
        : base(helpers, httpClient, logger)
    {
    }
}
