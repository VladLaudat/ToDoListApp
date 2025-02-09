using TodoListApp.WebApp.WebAPIServices;
using TodoListApp.WebApp.WebAPIServices.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

builder.Services.AddScoped<ITodoListWebApiService, TodoListWebApiService>();
builder.Services.AddScoped<TodoListApp.WebApp.WebAPIServices.Helpers.ITodoListHelpers, TodoListApp.WebApp.WebAPIServices.Helpers.TodoListHelpers>();
builder.Services.AddScoped<TodoListApp.WebApp.Controllers.Helpers.ITodoListHelpers, TodoListApp.WebApp.Controllers.Helpers.TodoListHelpers>();

builder.Services.AddScoped<ITaskWebApiService, TaskWebApiService>();
builder.Services.AddScoped<TodoListApp.WebApp.Controllers.Helpers.ITaskHelpers, TodoListApp.WebApp.Controllers.Helpers.TaskHelpers>();
builder.Services.AddScoped<TodoListApp.WebApp.WebAPIServices.Helpers.ITaskHelpers, TodoListApp.WebApp.WebAPIServices.Helpers.TaskHelpers>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TodoList}/{action=List}/{page}",
    defaults: new { page = 1 });

app.Run();
