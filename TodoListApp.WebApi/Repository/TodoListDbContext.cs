using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Repository.Entities;

namespace TodoListApp.WebApi.Repository;

public class TodoListDbContext : DbContext
{
    public TodoListDbContext(DbContextOptions<TodoListDbContext> options)
        : base(options)
    {
    }

    public DbSet<TodoListEntity> TodoList { get; set; }

    public DbSet<TaskEntity> Task { get; set; }

    public DbSet<TagEntity> Tag { get; set; }

    public DbSet<StatusEntity> Status { get; set; }

    public DbSet<CommentEntity> Comment { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        ArgumentNullException.ThrowIfNull(modelBuilder);

        // Seed data
        _ = modelBuilder.Entity<TodoListEntity>().HasData(
            new TodoListEntity { Id = 1, Description = "TodoListDescription1", Title = "TodoList1" },
            new TodoListEntity { Id = 2, Description = "TodoListDescription2", Title = "TodoList2" },
            new TodoListEntity { Id = 3, Description = "TodoListDescription3", Title = "TodoList3" },
            new TodoListEntity { Id = 4, Description = "TodoListDescription4", Title = "TodoList4" },
            new TodoListEntity { Id = 5, Description = "TodoListDescription5", Title = "TodoList5" },
            new TodoListEntity { Id = 6, Description = "TodoListDescription6", Title = "TodoList6" },
            new TodoListEntity { Id = 7, Description = "TodoListDescription7", Title = "TodoList7" },
            new TodoListEntity { Id = 8, Description = "TodoListDescription8", Title = "TodoList8" },
            new TodoListEntity { Id = 9, Description = "TodoListDescription9", Title = "TodoList9" },
            new TodoListEntity { Id = 10, Description = "TodoListDescription10", Title = "TodoList10" },
            new TodoListEntity { Id = 11, Description = "TodoListDescription11", Title = "TodoList11" },
            new TodoListEntity { Id = 12, Description = "TodoListDescription12", Title = "TodoList12" }
        );

        _ = modelBuilder.Entity<TaskEntity>().HasData(
            new TaskEntity { Id = 1, Description = "TaskDescription1", Title = "Task1", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(-1), StatusId = 1 },
            new TaskEntity { Id = 2, Description = "TaskDescription2", Title = "Task2", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 },
            new TaskEntity { Id = 3, Description = "TaskDescription3", Title = "Task3", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 },
            new TaskEntity { Id = 4, Description = "TaskDescription4", Title = "Task4", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 },
            new TaskEntity { Id = 5, Description = "TaskDescription5", Title = "Task5", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 },
            new TaskEntity { Id = 6, Description = "TaskDescription6", Title = "Task6", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(-1), StatusId = 1 },
            new TaskEntity { Id = 7, Description = "TaskDescription7", Title = "Task7", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 },
            new TaskEntity { Id = 8, Description = "TaskDescription8", Title = "Task8", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 },
            new TaskEntity { Id = 9, Description = "TaskDescription9", Title = "Task9", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 },
            new TaskEntity { Id = 10, Description = "TaskDescription10", Title = "Task10", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 },
            new TaskEntity { Id = 11, Description = "TaskDescription11", Title = "Task11", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 },
            new TaskEntity { Id = 12, Description = "TaskDescription12", Title = "Task12", CreatedDate = DateTime.Now, DueDate = DateTime.Now.AddDays(14), StatusId = 1 });

        _ = modelBuilder.Entity<TagEntity>().HasData(
            new TagEntity { Id = 1, Description = "TagDescription1" },
            new TagEntity { Id = 2, Description = "TagDescription2" });

        _ = modelBuilder.Entity<StatusEntity>().HasData(
            new StatusEntity { Id = 1, Description = "Not Started", IsActive = true },
            new StatusEntity { Id = 2, Description = "In Progess", IsActive = true },
            new StatusEntity { Id = 3, Description = "Completed", IsActive = false });

        _ = modelBuilder.Entity<CommentEntity>().HasData(
            new CommentEntity { Id = 1, Comment = "Comment1", TaskId = 1 },
            new CommentEntity { Id = 2, Comment = "Comment2", TaskId = 1 },
            new CommentEntity { Id = 3, Comment = "Comment3", TaskId = 1 });
    }
}
