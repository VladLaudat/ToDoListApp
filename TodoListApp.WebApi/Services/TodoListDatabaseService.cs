using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Models;
using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Services.Interfaces;
using TodoListApp.WebApi.Services.Logging;

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

    public IList<TodoListModel> Read(int page = 1, int pageSize = 4)
    {
        var resource = this.dbContext.TodoList.Skip((page - 1) * pageSize).Take(pageSize).Select(x => new TodoListModel()
        {
            Id = x.Id,
            Title = x.Title,
            Description = x.Description,
        }).ToList();

        this.logger.RetrievedTodoLists();

        return resource;
    }

    public void Add(TodoListModel model)
    {
        throw new NotImplementedException();
    }

    public void Delete(TodoListModel model)
    {
        throw new NotImplementedException();
    }


    public void Update(TodoListModel model)
    {
        throw new NotImplementedException();
    }
}
