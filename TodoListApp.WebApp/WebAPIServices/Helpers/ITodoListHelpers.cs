
namespace TodoListApp.WebApp.WebAPIServices.Helpers;

public interface ITodoListHelpers
{
    public Uri TodoListUpdateEndpointUriGenerator();

    public Uri TodoListDeleteEndpointUriGenerator(int id);

    Uri TodoListGetEndpointUriGenerator(int page);

    Uri TodoListGetByIdEndpointUriGenerator(int id);
}
