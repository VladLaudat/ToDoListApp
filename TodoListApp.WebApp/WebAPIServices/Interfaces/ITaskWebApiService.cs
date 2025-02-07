using TodoListApp.WebApp.ViewModels;

namespace TodoListApp.WebApp.WebAPIServices.Interfaces;

public interface ITaskWebApiService
{
    public Task<IList<TaskViewModel>> List(int page = 1);

    public Task<TaskViewModel> GetById(int id);

    public Task Add(TaskViewModel taskWebApiModel);

    public Task Update(TaskViewModel taskWebApiModel);

    public Task Delete(int id);

    public Task<int> Count();
}
