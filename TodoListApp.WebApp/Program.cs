using System.Globalization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApp.Controllers.Helpers;
using TodoListApp.WebApp.Identity;
using TodoListApp.WebApp.WebAPIServices;
using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Interfaces;
using TodoListApp.WebApp.WebAPIServices.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var defaultCulture = new CultureInfo("en-US");
    options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture(defaultCulture);
    options.SupportedCultures = new[] { defaultCulture };
    options.SupportedUICultures = new[] { defaultCulture };

    defaultCulture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
    defaultCulture.DateTimeFormat.LongTimePattern = "HH:mm:ss";
});

builder.Services.AddDbContext<UsersDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<UsersDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

builder.Services.AddScoped<IGenericServiceHelpers<TodoList>, GenericServiceHelpers<TodoList>>();
builder.Services.AddScoped<IGenericWebApiSerice<TodoList>, TodoListWebApiService>();
builder.Services.AddScoped<IGenericHelpers<TodoList>, GenericHelpers<TodoList>>();

builder.Services.AddScoped<IGenericServiceHelpers<TodoListApp.WebApp.WebAPIServices.Models.Task>, GenericServiceHelpers<TodoListApp.WebApp.WebAPIServices.Models.Task>>();
builder.Services.AddScoped<IGenericWebApiSerice<TodoListApp.WebApp.WebAPIServices.Models.Task>, TaskWebApiService>();
builder.Services.AddScoped<IGenericHelpers<TodoListApp.WebApp.WebAPIServices.Models.Task>, GenericHelpers<TodoListApp.WebApp.WebAPIServices.Models.Task>>();

builder.Services.AddScoped<IGenericWebApiSerice<Tag>, TagWebApiService>();
builder.Services.AddScoped<IGenericServiceHelpers<Tag>, GenericServiceHelpers<Tag>>();

builder.Services.AddScoped<IGenericWebApiSerice<Status>, StatusWebApiService>();
builder.Services.AddScoped<IGenericServiceHelpers<Status>, GenericServiceHelpers<Status>>();

builder.Services.AddScoped<IGenericWebApiSerice<Comment>, CommentWebApiService>();
builder.Services.AddScoped<IGenericServiceHelpers<Comment>, GenericServiceHelpers<Comment>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    _ = app.UseExceptionHandler("/Home/Error");

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    _ = app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TodoList}/{action=List}/{page}",
    defaults: new { page = 1 });

await app.RunAsync();
