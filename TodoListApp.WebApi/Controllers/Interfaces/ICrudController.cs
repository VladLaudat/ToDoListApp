using Microsoft.AspNetCore.Mvc;

namespace TodoListApp.WebApi.Controllers.Interfaces;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S3246:Generic type parameters should be co/contravariant when possible", Justification = "No need")]
public interface ICrudController<TEntity>
{
    public IActionResult List(int page = 1, int pageSize = 4);

    public IActionResult GetById(int id);

    public IActionResult Add(TEntity entity);

    public IActionResult Delete(int id);

    public IActionResult Update(TEntity entity);

    public IActionResult Count();
}
