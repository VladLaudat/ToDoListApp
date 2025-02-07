namespace TodoListApp.WebApp.WebAPIServices.Helpers;

public class TaskHelpers : ITaskHelpers
{
    private readonly IConfiguration configuration;

    public TaskHelpers(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public Uri TaskAddEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:Task:Controller"]}/{this.configuration["WebAPIURL:Endpoints:Task:Add"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri TaskCountEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:Task:Controller"]}/{this.configuration["WebAPIURL:Endpoints:Task:Count"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri TaskDeleteEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:Task:Controller"]}/{this.configuration["WebAPIURL:Endpoints:Task:Delete"]}",
            Query = $"id={id}",
        };

        return uriBuilder.Uri;
    }

    public Uri TaskGetByIdEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:Task:Controller"]}/{this.configuration["WebAPIURL:Endpoints:Task:GetById"]}",
            Query = $"id={id}",
        };

        return uriBuilder.Uri;
    }

    public Uri TaskGetEndpointUriGenerator(int page)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:Task:Controller"]}/{this.configuration["WebAPIURL:Endpoints:Task:Get"]}",
            Query = $"page={page}&pagesize={this.configuration["Constants:TaskListPageSize"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri TaskUpdateEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration["WebAPIURL:Endpoints:Task:Controller"]}/{this.configuration["WebAPIURL:Endpoints:Task:Update"]}",
        };

        return uriBuilder.Uri;
    }
}
