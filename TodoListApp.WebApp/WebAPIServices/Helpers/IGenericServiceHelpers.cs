namespace TodoListApp.WebApp.WebAPIServices.Helpers;

public interface IGenericServiceHelpers<TModel>
{
    public Uri UpdateEndpointUriGenerator();

    public Uri AddEndpointUriGenerator();

    public Uri DeleteEndpointUriGenerator(int id);

    Uri ListEndpointUriGenerator(int page);

    Uri GetByIdEndpointUriGenerator(int id);

    public Uri CountEndpointUriGenerator();
}
