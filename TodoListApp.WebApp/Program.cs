using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices;
using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

builder.Services.AddScoped<GenericWebApiService<TodoListViewModel, TodoListWebApiService>, TodoListWebApiService>();
builder.Services.AddScoped<IGenericServiceHelpers<TodoListViewModel>, GenericServiceHelpers<TodoListViewModel>>();
builder.Services.AddScoped<TodoListApp.WebApp.Controllers.Helpers.ITodoListHelpers, TodoListApp.WebApp.Controllers.Helpers.TodoListHelpers>();

builder.Services.AddScoped<GenericWebApiService<TaskViewModel, TaskWebApiService>, TaskWebApiService>();
builder.Services.AddScoped<IGenericServiceHelpers<TaskViewModel>, GenericServiceHelpers<TaskViewModel>>();
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
