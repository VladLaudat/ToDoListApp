using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices.Helpers;

namespace TodoListApp.WebApp.WebAPIServices;

public class TodoListWebApiService : GenericWebApiService<TodoListViewModel, TodoListWebApiService>
{
    public TodoListWebApiService(GenericServiceHelpers<TodoListViewModel> taskHelpers, HttpClient httpClient, ILogger<TodoListWebApiService> logger)
        : base(taskHelpers, httpClient, logger)
    {
    }

    /*public async Task<IList<TodoListViewModel>> List(int page = 1)
    {
        var uri = this.todoListHelpers.TodoListGetEndpointUriGenerator(page);

        var response = await this.httpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<List<TodoListViewModel>>(await response.Content.ReadAsStringAsync());

        this.logger.RetrievedTodoLists();
        return model ?? new List<TodoListViewModel>();
    }

    public async Task<TodoListViewModel> GetById(int id)
    {
        var uri = this.todoListHelpers.TodoListGetByIdEndpointUriGenerator(id);

        var response = await this.httpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<TodoListViewModel>(await response.Content.ReadAsStringAsync());

        this.logger.RetrievedTodoLists();
        return model ?? new TodoListViewModel();
    }

    public async Task Add(TodoListViewModel todoListWebApiModel)
    {
        var uri = this.todoListHelpers.TodoListAddEndpointUriGenerator();

        var json = JsonSerializer.Serialize(todoListWebApiModel);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this.httpClient.PostAsync(uri, content);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.logger.AddedTodoListSuccessfully();
        }
    }

    public async Task Delete(int id)
    {
        var uri = this.todoListHelpers.TodoListDeleteEndpointUriGenerator(id);

        var response = await this.httpClient.DeleteAsync(uri);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.logger.DeletedTodoListSuccessfully();
        }
    }

    public async Task Update(TodoListViewModel todoListWebApiModel)
    {
        var uri = this.todoListHelpers.TodoListUpdateEndpointUriGenerator();

        var json = JsonSerializer.Serialize(todoListWebApiModel);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this.httpClient.PutAsync(uri, content);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.logger.UpdatedTodoListSuccessfully();
        }
    }

    public async Task<int> Count()
    {
        var uri = this.todoListHelpers.TodoListCountEndpointUriGenerator();

        var response = await this.httpClient.GetAsync(uri);

        var count = JsonSerializer.Deserialize<int>(await response.Content.ReadAsStringAsync());

        this.logger.CountedTodoListSuccessfully();
        return count;
    }*/
}
