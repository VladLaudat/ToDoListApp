using TodoListApp.WebApp.Controllers.Helpers;
using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices;
using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Interfaces;
using TodoListApp.WebApp.WebAPIServices.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

builder.Services.AddScoped<IGenericServiceHelpers<TodoList>, GenericServiceHelpers<TodoList>>();
builder.Services.AddScoped<IGenericWebApiSerice<TodoList>, TodoListWebApiService>();
builder.Services.AddScoped<IGenericHelpers<TodoList>, GenericHelpers<TodoList>>();

builder.Services.AddScoped<IGenericServiceHelpers<TodoListApp.WebApp.WebAPIServices.Models.Task>, GenericServiceHelpers<TodoListApp.WebApp.WebAPIServices.Models.Task>>();
builder.Services.AddScoped<IGenericWebApiSerice<TodoListApp.WebApp.WebAPIServices.Models.Task>, TaskWebApiService>();
builder.Services.AddScoped<IGenericHelpers<TodoListApp.WebApp.WebAPIServices.Models.Task>, GenericHelpers<TodoListApp.WebApp.WebAPIServices.Models.Task>>();

/*builder.Services.AddScoped<IGenericWebApiSerice<Tag>, TagWebApiService>();
builder.Services.AddScoped<IGenericServiceHelpers<Tag>, GenericServiceHelpers<Tag>>();

builder.Services.AddScoped<IGenericWebApiSerice<Status>, StatusWebApiService>();
builder.Services.AddScoped<IGenericServiceHelpers<Status>, GenericServiceHelpers<Status>>();

builder.Services.AddScoped<IGenericWebApiSerice<Comment>, CommentWebApiService>();
builder.Services.AddScoped<IGenericServiceHelpers<Comment>, GenericServiceHelpers<Comment>>();*/

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
