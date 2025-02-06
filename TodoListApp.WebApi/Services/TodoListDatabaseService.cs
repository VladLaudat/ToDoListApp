using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Models;
using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Repository.Entities;
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
        var resource = this.dbContext.TodoList.Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Select(x => new TodoListModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
            }).ToList();

        this.logger.RetrievedTodoLists();

        return resource;
    }

    public TodoListModel ReadById(int id)
    {
        var entity = this.dbContext.TodoList.First(x => x.Id == id);
        var resource = new TodoListModel()
        {
            Id = entity.Id,
            Title = entity.Title,
            Description = entity.Description,
        };
        this.logger.RetrievedTodoListById();
        return resource;
    }

    public void Add(TodoListModel model)
    {
        ArgumentNullException.ThrowIfNull(model);

        _ = this.dbContext.Add(new TodoListEntity()
        {
            Id = model.Id,
            Title = model.Title,
            Description = model.Description,
        });

        _ = this.dbContext.SaveChanges();

        this.logger.AddedTodoList();
    }

    public void Delete(TodoListModel model)
    {
        ArgumentNullException.ThrowIfNull(model);

        _ = this.dbContext.Remove(new TodoListEntity()
        {
            Id = model.Id,
            Title = model.Title,
            Description = model.Description,
        });

        _ = this.dbContext.SaveChanges();

        this.logger.RemovedTodoList();
    }


    public void Update(TodoListModel model)
    {
        ArgumentNullException.ThrowIfNull(model);

        _ = this.dbContext.Update(new TodoListEntity()
        {
            Id = model.Id,
            Title = model.Title,
            Description = model.Description,
        });

        _ = this.dbContext.SaveChanges();

        this.logger.EditedTodoList();
    }
}
