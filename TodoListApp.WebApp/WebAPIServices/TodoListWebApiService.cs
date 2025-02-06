using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

    public async Task<TodoListListViewModel> GetById(int id)
    {
        var uri = this.todoListHelpers.TodoListGetByIdEndpointUriGenerator(id);

        var response = await this.httpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<TodoListListViewModel>(await response.Content.ReadAsStringAsync());

        this.logger.RetrievedTodoLists();
        return model ?? new TodoListListViewModel();
    }

    public Task Add(TodoListListViewModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public async Task Update(TodoListListViewModel todoListWebApiModel)
    {
        var uri = this.todoListHelpers.TodoListUpdateEndpointUriGenerator();

        var json = JsonSerializer.Serialize(todoListWebApiModel);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this.httpClient.PostAsync(uri, content);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.logger.UpdatedTodoListSuccessfully();
        }
    }
}
