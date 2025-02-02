using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApp.Models;
using TodoListApp.WebApp.WebAPIServices.Interfaces;

namespace TodoListApp.WebApp.Controllers;
public class TodoListController : Controller
{
    private readonly ITodoListWebApiService todoListWebApiService;
    private readonly ILogger<TodoListController> logger;

    public TodoListController(ITodoListWebApiService todoListWebApiService, ILogger<TodoListController> logger)
    {
        this.todoListWebApiService = todoListWebApiService;
        this.logger = logger;
    }

    public IActionResult GetAll()
    {
        throw new NotImplementedException();
    }

    public IActionResult Add(TodoListWebApiModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }

    public IActionResult Delete(TodoListWebApiModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }

    public IActionResult Update(TodoListWebApiModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }
}
