using System.Net;
using System.Text;
using System.Text.Json;
using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Interfaces;
using TodoListApp.WebApp.WebAPIServices.Logging;

namespace TodoListApp.WebApp.WebAPIServices;

public class TaskWebApiService : ITaskWebApiService
{
    private readonly ILogger<TaskWebApiService> logger;
    private readonly HttpClient httpClient;
    private readonly ITaskHelpers taskHelpers;

    public TaskWebApiService(ILogger<TaskWebApiService> logger, HttpClient httpClient, ITaskHelpers taskHelpers)
    {
        this.logger = logger;
        this.httpClient = httpClient;
        this.taskHelpers = taskHelpers;
    }

    public async Task<IList<TaskViewModel>> List(int page = 1)
    {
        var uri = this.taskHelpers.TaskGetEndpointUriGenerator(page);

        var response = await this.httpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<List<TaskViewModel>>(await response.Content.ReadAsStringAsync());

        this.logger.RetrievedTasks();
        return model ?? new List<TaskViewModel>();
    }

    public async Task Add(TaskViewModel taskWebApiModel)
    {
        var uri = this.taskHelpers.TaskAddEndpointUriGenerator();

        var json = JsonSerializer.Serialize(taskWebApiModel);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this.httpClient.PostAsync(uri, content);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.logger.AddedTaskSuccessfully();
        }
    }

    public async Task<int> Count()
    {
        var uri = this.taskHelpers.TaskCountEndpointUriGenerator();

        var response = await this.httpClient.GetAsync(uri);

        var count = JsonSerializer.Deserialize<int>(await response.Content.ReadAsStringAsync());

        this.logger.CountedTaskSuccessfully();
        return count;
    }

    public async Task Delete(int id)
    {
        var uri = this.taskHelpers.TaskGetByIdEndpointUriGenerator(id);

        var response = await this.httpClient.DeleteAsync(uri);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.logger.DeletedTaskSuccessfully();
        }
    }

    public async Task<TaskViewModel> GetById(int id)
    {
        var uri = this.taskHelpers.TaskGetByIdEndpointUriGenerator(id);

        var response = await this.httpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<TaskViewModel>(await response.Content.ReadAsStringAsync());

        this.logger.RetrievedTasks();
        return model ?? new TaskViewModel();
    }

    public async Task Update(TaskViewModel taskWebApiModel)
    {
        var uri = this.taskHelpers.TaskAddEndpointUriGenerator();

        var json = JsonSerializer.Serialize(taskWebApiModel);

        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this.httpClient.PutAsync(uri, content);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.logger.UpdatedTaskSuccessfully();
        }
    }
}
