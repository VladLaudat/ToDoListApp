using TodoListApp.WebApp.ViewModels;

namespace TodoListApp.WebApp.WebAPIServices.Interfaces;

public interface ITodoListWebApiService
{
    public Task<IList<TodoListListViewModel>> List(int page = 1);

    public void Add(TodoListListViewModel todoListWebApiModel);

    public void Update(TodoListListViewModel todoListWebApiModel);

    public void Delete(TodoListListViewModel todoListWebApiModel);
}
