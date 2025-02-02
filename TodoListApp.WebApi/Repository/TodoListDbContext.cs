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
}
