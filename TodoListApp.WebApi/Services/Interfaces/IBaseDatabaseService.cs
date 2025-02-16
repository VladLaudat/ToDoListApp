namespace TodoListApp.WebApi.Services.Interfaces;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public interface IBaseDatabaseService<TEntity>
{
    public IList<TEntity> Read(int page = 1, int pageSize = 4);

    public TEntity ReadById(int id);

    public void Add(TEntity entity);

    public void Update(TEntity entity);

    public void Delete(int id);

    public int Count();
}
