using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.WebAPIServices;

public class StatusWebApiService : GenericWebApiService<Status, StatusWebApiService>
{
    public StatusWebApiService(IGenericServiceHelpers<Status> helpers, HttpClient httpClient, ILogger<StatusWebApiService> logger)
        : base(helpers, httpClient, logger)
    {
    }
}
