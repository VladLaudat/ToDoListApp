using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Models;
using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;
using TodoListApp.WebApi.Services.Logging;

namespace TodoListApp.WebApi.Services;
public class TaskDatabaseService : ITaskDatabaseService
{
    private readonly ILogger<TaskDatabaseService> logger;
    private readonly TodoListDbContext dbContext;

    public TaskDatabaseService(TodoListDbContext dbContext, ILogger<TaskDatabaseService> logger)
    {
        this.dbContext = dbContext;
        this.logger = logger;
    }

    public void Add(TaskModel model)
    {
        ArgumentNullException.ThrowIfNull(model);

        _ = this.dbContext.Add(new TaskEntity()
        {
            Id = model.Id,
            Title = model.Title,
            Description = model.Description,
            CreatedDate = DateTime.Now,
            DueDate = model.DueDate,
            Status = model.Status,
            Tags = model.Tags,
            TodoList = model.TodoList,
        });

        _ = this.dbContext.SaveChanges();

        this.logger.AddedTask();
    }

    public int Count()
    {
        var count = this.dbContext.Task.Count();

        this.logger.CountedTasks();

        return count;
    }

    public void Delete(int id)
    {
        var model = this.dbContext.Task.First(x => x.Id == id);

        _ = this.dbContext.Remove(model);

        _ = this.dbContext.SaveChanges();

        this.logger.RemovedTask();
    }

    public IList<TaskModel> Read(int page = 1, int pageSize = 4)
    {
        var resource = this.dbContext.Task.Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Select(x => new TaskModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                CreatedDate = x.CreatedDate,
                DueDate = x.DueDate,
            }).ToList();

        this.logger.RetrievedTasks();

        return resource;
    }

    public TaskModel ReadById(int id)
    {
        var entity = this.dbContext.Task
            .Include(x => x.Status)
            .Include(x => x.TodoList)
            .Include(x => x.Status)
            .First(x => x.Id == id);

        var resource = new TaskModel()
        {
            Id = entity.Id,
            Title = entity.Title,
            Description = entity.Description,
            CreatedDate = entity.CreatedDate,
            DueDate = entity.DueDate,
            Status = entity.Status,
            TodoList = entity.TodoList,
            Tags = entity.Tags,
        };

        this.logger.RetrievedTaskById();
        return resource;
    }

    public void Update(TaskModel model)
    {
        ArgumentNullException.ThrowIfNull(model);

        _ = this.dbContext.Update(new TaskEntity()
        {
            Id = model.Id,
            Title = model.Title,
            Description = model.Description,
        });

        _ = this.dbContext.SaveChanges();

        this.logger.EditedTask();
    }
}
