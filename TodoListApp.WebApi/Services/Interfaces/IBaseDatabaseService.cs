using TodoListApp.WebApi.Models;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Services.Interfaces;

public interface IBaseDatabaseService<TEntity>
{
    public IList<TEntity> Read(int page = 1, int pageSize = 4);

    public TEntity ReadById(int id);

    public void Add(TEntity entity);

    public void Update(TEntity entity);

    public void Delete(int id);

    public int Count();
}
