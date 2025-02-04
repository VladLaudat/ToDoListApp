using System.Collections.ObjectModel;
using System.Data.Common;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApi.Controllers.Logging;
using TodoListApp.WebApi.Models;
using TodoListApp.WebApi.Services;
using TodoListApp.WebApi.Services.Interfaces;
using TodoListApp.WebApi.Services.Logging;

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

    [HttpGet]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(int), StatusCodes.Status500InternalServerError)]
    public IActionResult Get([FromQuery] int page = 1, [FromQuery] int pageSize = 4)
    {
        try
        {
            var response = this.Ok(this.todoListDatabaseService.Read(page, pageSize));
            this.logger.RequestSuccesfullyHandled();
            return response;
        }
        catch (DbException ex)
        {
            this.logger.DbThrewException(ex);
            return this.StatusCode(500);
        }
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
