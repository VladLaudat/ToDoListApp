using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApi.Models;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Controllers;
[Route("[controller]/[action]")]
[ApiController]
public class TodoListController : ControllerBase
{
    private readonly ILogger<TodoListController> logger;
    private readonly ITodoListDatabaseService todoListDatabaseService;

    public TodoListController(ITodoListDatabaseService todoListDatabaseService, ILogger<TodoListController> logger)
    {
        this.todoListDatabaseService = todoListDatabaseService;
        this.logger = logger;
    }

    public IActionResult GetAll()
    {
        throw new NotImplementedException();
    }

    public IActionResult Add(TodoListModel model)
    {
        throw new NotImplementedException();
    }

    public IActionResult Delete(TodoListModel model)
    {
        throw new NotImplementedException();
    }

    public IActionResult Update(TodoListModel model)
    {
        throw new NotImplementedException();
    }
}
