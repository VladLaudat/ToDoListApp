using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices.Interfaces;

namespace TodoListApp.WebApp.WebAPIServices;

public class TaskWebApiService : ITaskWebApiService
{
    public Task Add(TaskViewModel taskWebApiModel)
    {
        throw new NotImplementedException();
    }

    public Task<int> Count()
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<TaskViewModel> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IList<TaskViewModel>> List(int page = 1)
    {
        throw new NotImplementedException();
    }

    public Task Update(TaskViewModel taskWebApiModel)
    {
        throw new NotImplementedException();
    }
}
