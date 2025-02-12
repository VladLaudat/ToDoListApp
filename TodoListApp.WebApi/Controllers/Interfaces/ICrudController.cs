using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Controllers.Interfaces;

public interface ICrudController<TEntity>
{
    public IActionResult List(int page = 1, int pageSize = 4);

    public IActionResult GetById(int id);

    public IActionResult Add(TEntity entity);

    public IActionResult Delete(int id);

    public IActionResult Update(TEntity entity);

    public IActionResult Count();
}
