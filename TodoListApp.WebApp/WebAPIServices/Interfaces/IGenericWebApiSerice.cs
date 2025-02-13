using TodoListApp.WebApp.ViewModels;

namespace TodoListApp.WebApp.WebAPIServices.Interfaces;

public interface IGenericWebApiSerice<TViewModel>
{
    public Task<IList<TViewModel>> List(int page = 1);

    public Task<TViewModel?> GetById(int id);

    public Task Add(TViewModel webApiModel);

    public Task Update(TViewModel webApiModel);

    public Task Delete(int id);

    public Task<int> Count();
}
