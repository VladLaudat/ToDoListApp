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

        // Seed data
        _ = modelBuilder.Entity<TodoListEntity>().HasData(
            new TodoListEntity { Id = 1, Description = "Description1", Title = "TodoList1" },
            new TodoListEntity { Id = 2, Description = "Description2", Title = "TodoList2" },
            new TodoListEntity { Id = 3, Description = "Description3", Title = "TodoList3" },
            new TodoListEntity { Id = 4, Description = "Description4", Title = "TodoList4" },
            new TodoListEntity { Id = 5, Description = "Description5", Title = "TodoList5" },
            new TodoListEntity { Id = 6, Description = "Description6", Title = "TodoList6" },
            new TodoListEntity { Id = 7, Description = "Description7", Title = "TodoList7" },
            new TodoListEntity { Id = 8, Description = "Description8", Title = "TodoList8" },
            new TodoListEntity { Id = 9, Description = "Description9", Title = "TodoList9" },
            new TodoListEntity { Id = 10, Description = "Description10", Title = "TodoList10" },
            new TodoListEntity { Id = 11, Description = "Description11", Title = "TodoList11" },
            new TodoListEntity { Id = 12, Description = "Description12", Title = "TodoList12" }
        );
    }
}
