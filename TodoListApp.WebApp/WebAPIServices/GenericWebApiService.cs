using System.Net;
using System.Text;
using System.Text.Json;
using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Interfaces;
using TodoListApp.WebApp.WebAPIServices.Logging;
using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.WebAPIServices;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public class GenericWebApiService<TModel, TService> : IGenericWebApiSerice<TModel>
    where TModel : BaseModel
    where TService : GenericWebApiService<TModel, TService>
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S6672:Generic logger injection should match enclosing type", Justification = "Misfire")]
    public GenericWebApiService(IGenericServiceHelpers<TModel> helpers, HttpClient httpClient, ILogger<TService> logger)
    {
        this.Logger = logger;
        this.HttpClient = httpClient;
        this.Helpers = helpers;
    }

    protected ILogger<TService> Logger { get; }

    protected HttpClient HttpClient { get; }

    protected IGenericServiceHelpers<TModel> Helpers { get; }

    public async System.Threading.Tasks.Task Add(TModel webApiModel)
    {
        var uri = this.Helpers.AddEndpointUriGenerator();

        var json = JsonSerializer.Serialize(webApiModel);

        using var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this.HttpClient.PostAsync(uri, content);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.Logger.ApiAddRequestSuccessful<TModel>();
        }
    }

    public async Task<int> Count()
    {
        var uri = this.Helpers.CountEndpointUriGenerator();

        var response = await this.HttpClient.GetAsync(uri);

        var count = JsonSerializer.Deserialize<int>(await response.Content.ReadAsStringAsync());

        this.Logger.ApiCountRequestSuccessful<TModel>();
        return count;
    }

    public async System.Threading.Tasks.Task Delete(int id)
    {
        var uri = this.Helpers.DeleteEndpointUriGenerator(id);

        var response = await this.HttpClient.DeleteAsync(uri);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.Logger.ApiDeleteRequestSuccessful<TModel>();
        }
    }

    public async Task<TModel?> GetById(int id)
    {
        var uri = this.Helpers.GetByIdEndpointUriGenerator(id);

        var response = await this.HttpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<TModel>(await response.Content.ReadAsStringAsync());

        this.Logger.ApiRetieveByIdRequestSuccessful<TModel>();
        return model;
    }

    public async Task<IList<TModel>> List(int page = 1)
    {
        var uri = this.Helpers.ListEndpointUriGenerator(page);

        var response = await this.HttpClient.GetAsync(uri);

        var model = JsonSerializer.Deserialize<List<TModel>>(await response.Content.ReadAsStringAsync());

        this.Logger.ApiListRequestSuccessful<TModel>();

        return model ?? new List<TModel>();
    }

    public async System.Threading.Tasks.Task Update(TModel webApiModel)
    {
        var uri = this.Helpers.UpdateEndpointUriGenerator();

        var json = JsonSerializer.Serialize(webApiModel);

        using var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await this.HttpClient.PutAsync(uri, content);

        if (response.EnsureSuccessStatusCode().StatusCode == HttpStatusCode.OK)
        {
            this.Logger.ApiUpdateRequestSuccessful<TModel>();
        }
    }
}
