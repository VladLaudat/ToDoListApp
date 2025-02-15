namespace TodoListApp.WebApp.Controllers.Helpers;

public interface IGenericHelpers<TModel>
{
    public Task<int> TotalPages();
}
