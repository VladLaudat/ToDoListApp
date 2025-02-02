using TodoListApp.WebApp.Models;

namespace TodoListApp.WebApp.WebAPIServices.Interfaces;

public interface ITodoListWebApiService
{
    public ICollection<TodoListWebApiModel> GetAll();

    public void Add(TodoListWebApiModel todoListWebApiModel);

    public void Update(TodoListWebApiModel todoListWebApiModel);

    public void Delete(TodoListWebApiModel todoListWebApiModel);
}
