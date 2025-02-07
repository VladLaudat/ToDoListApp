namespace TodoListApp.WebApp.WebAPIServices.Helpers;

public interface ITaskHelpers
{
    public Uri TaskUpdateEndpointUriGenerator();

    public Uri TaskAddEndpointUriGenerator();

    public Uri TaskDeleteEndpointUriGenerator(int id);

    Uri TaskGetEndpointUriGenerator(int page);

    Uri TaskGetByIdEndpointUriGenerator(int id);

    public Uri TaskCountEndpointUriGenerator();
}
