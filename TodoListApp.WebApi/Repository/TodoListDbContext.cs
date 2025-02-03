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
}
