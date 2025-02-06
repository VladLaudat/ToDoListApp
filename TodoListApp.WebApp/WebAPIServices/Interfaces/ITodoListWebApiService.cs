using TodoListApp.WebApp.ViewModels;

namespace TodoListApp.WebApp.WebAPIServices.Interfaces;

public interface ITodoListWebApiService
{
    public Task<IList<TodoListListViewModel>> List(int page = 1);

    public Task<TodoListListViewModel> GetById(int id);

    public Task Add(TodoListListViewModel todoListWebApiModel);

    public Task Update(TodoListListViewModel todoListWebApiModel);

    public Task Delete(int id);
}
