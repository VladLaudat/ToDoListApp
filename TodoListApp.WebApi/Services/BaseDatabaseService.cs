using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Services;

public class BaseDatabaseService<TEntity, TService> : IBaseDatabaseService<TEntity>
    where TEntity : BaseEntity
    where TService : BaseDatabaseService<TEntity, TService>
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S6672:Generic logger injection should match enclosing type", Justification = "Misfire")]
    public BaseDatabaseService(TodoListDbContext dbContext, ILogger<TService> logger)
    {
        this.DbContext = dbContext;
        this.Logger = logger;
    }

    protected ILogger<TService> Logger { get; }

    protected TodoListDbContext DbContext { get; }

    public virtual void Add(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        _ = this.DbContext.Set<TEntity>().Add(entity);

        _ = this.DbContext.SaveChanges();
    }

    public virtual void Delete(int id)
    {
        var entity = this.DbContext.Set<TEntity>().FirstOrDefault(x => x.Id == id);

        if (entity == null)
        {
            return;
        }

        _ = this.DbContext.Remove(entity);
        _ = this.DbContext.SaveChanges();
    }

    public virtual IList<TEntity> Read(int page = 1, int pageSize = 4)
    {
        var entities = this.DbContext.Set<TEntity>().
            Skip((page - 1) * pageSize)
            .Take(pageSize).ToList();

        return entities;
    }

    public virtual TEntity ReadById(int id)
    {
        var entity = this.DbContext.Set<TEntity>().First(x => x.Id == id);

        return entity;
    }

    public virtual void Update(TEntity entity)
    {
        var entityExists = this.DbContext.Set<TEntity>().Any(x => x.Id == entity.Id);

        if (!entityExists)
        {
            return;
        }

        _ = this.DbContext.Set<TEntity>().Update(entity);
        _ = this.DbContext.SaveChanges();
    }

    public virtual int Count()
    {
        var count = this.DbContext.Set<TEntity>().Count();

        return count;
    }
}
