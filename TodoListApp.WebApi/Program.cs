using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApi.Filters;
using TodoListApp.WebApi.Repository;
using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services;
using TodoListApp.WebApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(cfg =>
{
    _ = cfg.Filters.Add<Exception500Filter>();
});
builder.Services.AddDbContext<TodoListDbContext>(options =>
{
    _ = options.UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]);
});
builder.Services.AddScoped<IBaseDatabaseService<TodoListEntity>, TodoListDatabaseService>();
builder.Services.AddScoped<IBaseDatabaseService<TaskEntity>, TaskDatabaseService>();
builder.Services.AddScoped<IBaseDatabaseService<CommentEntity>, CommentDatabaseService>();
builder.Services.AddScoped<IBaseDatabaseService<TagEntity>, TagDatabaseService>();
builder.Services.AddScoped<IBaseDatabaseService<StatusEntity>, StatusDatabaseService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();
