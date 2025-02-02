using TodoListApp.WebApp.Models;
using TodoListApp.WebApp.WebAPIServices.Interfaces;

namespace TodoListApp.WebApp.WebAPIServices;

public class TodoListWebApiService : ITodoListWebApiService
{
    private readonly ILogger<TodoListWebApiService> logger;

    public TodoListWebApiService(ILogger<TodoListWebApiService> logger)
    {
        this.logger = logger;
    }

    public void Add(TodoListWebApiModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }

    public void Delete(TodoListWebApiModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }

    public ICollection<TodoListWebApiModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(TodoListWebApiModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }
}
