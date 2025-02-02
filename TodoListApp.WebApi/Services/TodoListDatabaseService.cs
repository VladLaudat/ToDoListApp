using System.Collections.ObjectModel;
using TodoListApp.WebApi.Models;
using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Services;

public class TodoListDatabaseService : ITodoListDatabaseService
{
    private readonly ILogger<TodoListDatabaseService> logger;
    private readonly TodoListDbContext dbContext;

    public TodoListDatabaseService(TodoListDbContext dbContext, ILogger<TodoListDatabaseService> logger)
    {
        this.dbContext = dbContext;
        this.logger = logger;
    }

    public void Add(TodoListModel model)
    {
        throw new NotImplementedException();
    }

    public void Delete(TodoListModel model)
    {
        throw new NotImplementedException();
    }

    public Collection<TodoListModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(TodoListModel model)
    {
        throw new NotImplementedException();
    }

    ICollection<TodoListModel> ITodoListDatabaseService.GetAll()
    {
        throw new NotImplementedException();
    }
}
