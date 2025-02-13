namespace TodoListApp.WebApp.WebAPIServices.Helpers;

public interface IGenericServiceHelpers
{
    public Uri UpdateEndpointUriGenerator();

    public Uri AddEndpointUriGenerator();

    public Uri DeleteEndpointUriGenerator(int id);

    Uri GetEndpointUriGenerator(int page);

    Uri GetByIdEndpointUriGenerator(int id);

    public Uri CountEndpointUriGenerator();
}
