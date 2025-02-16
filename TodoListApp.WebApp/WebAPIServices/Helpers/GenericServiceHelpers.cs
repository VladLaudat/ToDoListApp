namespace TodoListApp.WebApp.WebAPIServices.Helpers;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public class GenericServiceHelpers<TModel> : IGenericServiceHelpers<TModel>
{
    private readonly IConfiguration configuration;
    private readonly string modelName = typeof(TModel).Name;

    public GenericServiceHelpers(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public Uri AddEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Add"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri CountEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Count"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri DeleteEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Delete"]}",
            Query = $"{nameof(id)}={id}",
        };

        return uriBuilder.Uri;
    }

    public Uri GetByIdEndpointUriGenerator(int id)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:GetById"]}",
            Query = $"{nameof(id)}={id}",
        };

        return uriBuilder.Uri;
    }

    public Uri ListEndpointUriGenerator(int page)
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];
        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:List"]}",
            Query = $"{nameof(page)}={page}&pagesize={this.configuration["Constants:ListingEndpointsPageSize"]}",
        };

        return uriBuilder.Uri;
    }

    public Uri UpdateEndpointUriGenerator()
    {
        string baseURL = this.configuration["WebAPIURL:BaseURL"];

        var uriBuilder = new UriBuilder(baseURL)
        {
            Path = $"{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Controller"]}/{this.configuration[$"WebAPIURL:Endpoints:{this.modelName}:Update"]}",
        };

        return uriBuilder.Uri;
    }
}
