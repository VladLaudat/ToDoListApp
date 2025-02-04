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
    private readonly IConfiguration configuration;

    public TodoListWebApiService(ILogger<TodoListWebApiService> logger, HttpClient httpClient, IConfiguration configuration)
    {
        this.logger = logger;
        this.httpClient = httpClient;
        this.configuration = configuration;
    }

    public async Task<IList<TodoListListViewModel>> List(int page = 1)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:TodoList:Controller"]}/{this.configuration["WebAPIURL:Endpoints:TodoList:Get"]}",
            Query = $"page={page}&pagesize={TodoListHelpers.TodoListListPageSize}",
        };

        var uri = uriBuilder.Uri;
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
