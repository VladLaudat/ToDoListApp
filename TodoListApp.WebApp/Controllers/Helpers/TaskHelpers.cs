
using TodoListApp.WebApp.WebAPIServices.Interfaces;

namespace TodoListApp.WebApp.Controllers.Helpers;

public class TaskHelpers : ITaskHelpers
{
    private readonly IConfiguration configuration;
    private readonly ITaskWebApiService taskWebApiService;

    public TaskHelpers(IConfiguration configuration, ITaskWebApiService taskWebApiService)
    {
        this.configuration = configuration;
        this.taskWebApiService = taskWebApiService;
    }

    public async Task<int> TotalPages()
    {
        var count = await this.taskWebApiService.Count();

        if (int.TryParse(this.configuration["Constants:TaskListPageSize"], out int taskListPageSize))
        {
            decimal pages = Math.Ceiling((decimal)count / taskListPageSize);
            return (int)pages;
        }

        return 0;
    }
}
