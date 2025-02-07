using TodoListApp.WebApp.WebAPIServices.Interfaces;

namespace TodoListApp.WebApp.Controllers.Helpers;

public class TodoListHelpers : ITodoListHelpers
{
    private readonly IConfiguration configuration;
    private readonly ITodoListWebApiService todoListWebApiService;

    public TodoListHelpers(IConfiguration configuration, ITodoListWebApiService todoListWebApiService)
    {
        this.configuration = configuration;
        this.todoListWebApiService = todoListWebApiService;
    }

    public async Task<int> TotalPages()
    {
        var count = await this.todoListWebApiService.Count();

        if (int.TryParse(this.configuration["Constants:TodoListListPageSize"], out int todoListListPageSize))
        {
            decimal pages = Math.Ceiling((decimal)count / todoListListPageSize);
            return (int)pages;
        }

        return 0;
    }
}
