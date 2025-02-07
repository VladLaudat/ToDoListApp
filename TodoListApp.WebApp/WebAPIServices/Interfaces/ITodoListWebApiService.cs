using TodoListApp.WebApp.ViewModels;

namespace TodoListApp.WebApp.WebAPIServices.Interfaces;

public interface ITodoListWebApiService
{
    public Task<IList<TodoListViewModel>> List(int page = 1);

    public Task<TodoListViewModel> GetById(int id);

    public Task Add(TodoListViewModel todoListWebApiModel);

    public Task Update(TodoListViewModel todoListWebApiModel);

    public Task Delete(int id);

    public Task<int> Count();
}
