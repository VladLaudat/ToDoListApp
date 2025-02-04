
namespace TodoListApp.WebApp.WebAPIServices.Helpers;

public interface ITodoListHelpers
{
    Uri TodoListGetEndpointUriGenerator(int page);
}