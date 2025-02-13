using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TodoListApp.WebApp.WebAPIServices.Helpers;

public class GenericServiceHelpers<TViewModel> : IGenericServiceHelpers
{
    private readonly IConfiguration configuration;

    public GenericServiceHelpers(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public Uri AddEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Add"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri CountEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Count"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri DeleteEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Delete"]}",
            Query = $"{nameof(id)}={id}",
        };

        return uriBuilder.Uri;
    }

    public Uri GetByIdEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:GetById"]}",
            Query = $"{nameof(id)}={id}",
        };

        return uriBuilder.Uri;
    }

    public Uri GetEndpointUriGenerator(int page)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Get"]}",
            Query = $"{nameof(page)}={page}",
        };

        return uriBuilder.Uri;
    }

    public Uri UpdateEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TViewModel)}:Update"]}",
        };

        return uriBuilder.Uri;
    }
}
