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

    public void Add(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);

        _ = this.DbContext.Set<TEntity>().Add(entity);

        _ = this.DbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = this.DbContext.Set<TEntity>().FirstOrDefault(x => x.Id == id);

        if (entity == null)
        {
            return;
        }

        _ = this.DbContext.Remove(entity);
        _ = this.DbContext.SaveChanges();
    }

    public IList<TEntity> Read(int page = 1, int pageSize = 4)
    {
        var entities = this.DbContext.Set<TEntity>().
            Skip((page - 1) * pageSize)
            .Take(pageSize).ToList();

        return entities;
    }

    public TEntity ReadById(int id)
    {
        var entity = this.DbContext.Set<TEntity>().First(x => x.Id == id);

        return entity;
    }

    public void Update(TEntity entity)
    {
        var matchingEntity = this.DbContext.Set<TEntity>().FirstOrDefault(x => x.Id == entity.Id);

        if (matchingEntity == null)
        {
            return;
        }

        _ = this.DbContext.Set<TEntity>().Update(entity);
        _ = this.DbContext.SaveChanges();
    }
}
