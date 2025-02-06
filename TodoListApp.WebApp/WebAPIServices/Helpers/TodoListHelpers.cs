namespace TodoListApp.WebApp.WebAPIServices.Helpers;

public class TodoListHelpers : ITodoListHelpers
{
    /// <summary>
    /// Constant for page sizing when calling WEB API.
    /// </summary>
    private const int TodoListListPageSize = 9;

    private readonly IConfiguration configuration;

    public TodoListHelpers(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public Uri TodoListUpdateEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:TodoList:Controller"]}/{this.configuration["WebAPIURL:Endpoints:TodoList:Update"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri TodoListGetByIdEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:TodoList:Controller"]}/{this.configuration["WebAPIURL:Endpoints:TodoList:GetById"]}",
            Query = $"id={id}",
        };

        return uriBuilder.Uri;
    }

    public Uri TodoListGetEndpointUriGenerator(int page)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:TodoList:Controller"]}/{this.configuration["WebAPIURL:Endpoints:TodoList:Get"]}",
            Query = $"page={page}&pagesize={TodoListListPageSize}",
        };

        return uriBuilder.Uri;
    }

    public Uri TodoListDeleteEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:TodoList:Controller"]}/{this.configuration["WebAPIURL:Endpoints:TodoList:Delete"]}",
        };

        return uriBuilder.Uri;
    }
}
