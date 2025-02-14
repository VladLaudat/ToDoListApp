using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TodoListApp.WebApp.WebAPIServices.Helpers;

public class GenericServiceHelpers<TModel> : IGenericServiceHelpers<TModel>
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
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Add"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri CountEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Count"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri DeleteEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Delete"]}",
            Query = $"{nameof(id)}={id}",
        };

        return uriBuilder.Uri;
    }

    public Uri GetByIdEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:GetById"]}",
            Query = $"{nameof(id)}={id}",
        };

        return uriBuilder.Uri;
    }

    public Uri ListEndpointUriGenerator(int page)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:List"]}",
            Query = $"{nameof(page)}={page}&pagesize={this.configuration["Constants:ListingEndpointsPageSize"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri UpdateEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{nameof(TModel)}:Update"]}",
        };

        return uriBuilder.Uri;
    }
}
