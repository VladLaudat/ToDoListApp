namespace TodoListApp.WebApp.WebAPIServices.Interfaces;

public interface IGenericWebApiSerice<TModel>
{
    public Task<IList<TModel>> List(int page = 1);

    public Task<TModel?> GetById(int id);

    public Task Add(TModel webApiModel);

    public Task Update(TModel webApiModel);

    public Task Delete(int id);

    public Task<int> Count();
}
