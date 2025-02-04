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
            new TodoListEntity { Id = 1, Description = "Description1", Title = "Title1" },
            new TodoListEntity { Id = 2, Description = "Description2", Title = "Title2" },
            new TodoListEntity { Id = 3, Description = "Description3", Title = "Title3" }
        );
    }
}
