using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Services;
using TodoListApp.WebApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoListDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]);
});
builder.Services.AddScoped<ITodoListDatabaseService, TodoListDatabaseService>();
builder.Services.AddScoped<ITaskDatabaseService, TaskDatabaseService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
