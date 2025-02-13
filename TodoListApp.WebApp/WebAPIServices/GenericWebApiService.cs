using System.Net;
using System.Text.Json;
using System.Text;
using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Interfaces;
using TodoListApp.WebApp.WebAPIServices.Logging;
using TodoListApp.WebApp.ViewModels;

namespace TodoListApp.WebApp.WebAPIServices;

public class GenericWebApiService<TViewModel, TService> : IGenericWebApiSerice<TViewModel>
    where TService : GenericWebApiService<TViewModel, TService>
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S6672:Generic logger injection should match enclosing type", Justification = "Misfire")]
    public GenericWebApiService(GenericServiceHelpers<TViewModel> helpers, HttpClient httpClient, ILogger<TService> logger)
    {
        this.Logger = logger;
        this.HttpClient = httpClient;
        this.Helpers = helpers;
    }

    protected ILogger<TService> Logger { get; }

    protected HttpClient HttpClient { get; }

    protected GenericServiceHelpers<TViewModel> Helpers { get; }

    public async Task Add(TViewModel webApiModel)
    {
        var uri = this.Helpers.AddEndpointUriGenerator();

        var json = JsonSerializer.Serialize(webApiModel);

        using var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this.HttpClient.PostAsync(uri, content);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.Logger.ApiAddRequestSuccessful<TViewModel>();
        }
    }

    public async Task<int> Count()
    {
        var uri = this.Helpers.CountEndpointUriGenerator();

        var response = await this.HttpClient.GetAsync(uri);

        var count = JsonSerializer.Deserialize<int>(await response.Content.ReadAsStringAsync());

        this.Logger.ApiCountRequestSuccessful<TViewModel>();
        return count;
    }

    public async Task Delete(int id)
    {
        var uri = this.Helpers.DeleteEndpointUriGenerator(id);

        var response = await this.HttpClient.DeleteAsync(uri);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.Logger.ApiDeleteRequestSuccessful<TViewModel>();
        }
    }

    public async Task<TViewModel?> GetById(int id)
    {
        var uri = this.Helpers.GetByIdEndpointUriGenerator(id);

        var response = await this.HttpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<TViewModel>(await response.Content.ReadAsStringAsync());

        this.Logger.ApiRetieveByIdRequestSuccessful<TViewModel>();
        return model;
    }

    public async Task<IList<TViewModel>> List(int page = 1)
    {
        var uri = this.Helpers.ListEndpointUriGenerator(page);

        var response = await this.HttpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<List<TViewModel>>(await response.Content.ReadAsStringAsync());

        this.Logger.ApiListRequestSuccessful<TViewModel>();

        return model ?? new List<TViewModel>();
    }

    public async Task Update(TViewModel webApiModel)
    {
        var uri = this.Helpers.UpdateEndpointUriGenerator();

        var json = JsonSerializer.Serialize(webApiModel);

        using var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this.HttpClient.PutAsync(uri, content);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.Logger.ApiUpdateRequestSuccessful<TViewModel>();
        }
    }
}
