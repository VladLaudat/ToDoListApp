using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.WebAPIServices.Interfaces;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
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
