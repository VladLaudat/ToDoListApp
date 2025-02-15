using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.WebAPIServices.Interfaces;

public interface IGenericWebApiSerice<TModel>
    where TModel : BaseModel
{
    public Task<IList<TModel>> List(int page = 1);

    public Task<TModel?> GetById(int id);

    public System.Threading.Tasks.Task Add(TModel webApiModel);

    public System.Threading.Tasks.Task Update(TModel webApiModel);

    public System.Threading.Tasks.Task Delete(int id);

    public Task<int> Count();
}
