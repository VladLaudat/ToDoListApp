using System.Text.Json;
using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Interfaces;
using TodoListApp.WebApp.WebAPIServices.Logging;

namespace TodoListApp.WebApp.WebAPIServices;

public class TodoListWebApiService : ITodoListWebApiService
{
    private readonly ILogger<TodoListWebApiService> logger;
    private readonly HttpClient httpClient;
    private readonly ITodoListHelpers todoListHelpers;

    public TodoListWebApiService(ILogger<TodoListWebApiService> logger, HttpClient httpClient, ITodoListHelpers todoListHelpers)
    {
        this.logger = logger;
        this.httpClient = httpClient;
        this.todoListHelpers = todoListHelpers;

    }

    public async Task<IList<TodoListListViewModel>> List(int page = 1)
    {
        var uri = this.todoListHelpers.TodoListGetEndpointUriGenerator(page);

        var response = await this.httpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<List<TodoListListViewModel>>(await response.Content.ReadAsStringAsync());

        this.logger.RetrievedTodoLists();
        return model ?? new List<TodoListListViewModel>();
    }

    public void Add(TodoListListViewModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }

    public void Delete(TodoListListViewModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }

    public void Update(TodoListListViewModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }
}
