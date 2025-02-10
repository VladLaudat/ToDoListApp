using System.Collections.ObjectModel;
using System.Data.Common;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoListApp.WebApi.Controllers.Logging;
using TodoListApp.WebApi.Models;
using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services;
using TodoListApp.WebApi.Services.Interfaces;
using TodoListApp.WebApi.Services.Logging;

namespace TodoListApp.WebApi.Controllers;
[Route("[controller]/[action]")]
[ApiController]
public class TodoListController : ControllerBase
{
    private readonly ILogger<TodoListController> logger;
    private readonly IBaseDatabaseService<TodoListEntity> todoListDatabaseService;

    public TodoListController(IBaseDatabaseService<TodoListEntity> todoListDatabaseService, ILogger<TodoListController> logger)
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

    [HttpGet]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(int), StatusCodes.Status500InternalServerError)]
    public IActionResult GetById([FromQuery] int id)
    {
        try
        {
            var response = this.Ok(this.todoListDatabaseService.ReadById(id));
            this.logger.RequestSuccesfullyHandled();
            return response;
        }
        catch (DbException ex)
        {
            this.logger.DbThrewException(ex);
            return this.StatusCode(500);
        }
    }

    [HttpPost]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(int), StatusCodes.Status500InternalServerError)]
    public IActionResult Add(TodoListModel model)
    {
        try
        {
            this.todoListDatabaseService.Add(model);
            this.logger.RequestSuccesfullyHandled();
            return this.Ok();
        }
        catch (DbException ex)
        {
            this.logger.DbThrewException(ex);
            return this.StatusCode(500);
        }
    }

    [HttpDelete]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(int), StatusCodes.Status500InternalServerError)]
    public IActionResult Delete(int id)
    {
        try
        {
            this.todoListDatabaseService.Delete(id);
            this.logger.RequestSuccesfullyHandled();
            return this.Ok();
        }
        catch (DbException ex)
        {
            this.logger.DbThrewException(ex);
            return this.StatusCode(500);
        }
    }

    [HttpPut]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(int), StatusCodes.Status500InternalServerError)]
    public IActionResult Update(TodoListModel model)
    {
        try
        {
            this.todoListDatabaseService.Update(model);
            this.logger.RequestSuccesfullyHandled();
            return this.Ok();
        }
        catch (DbException ex)
        {
            this.logger.DbThrewException(ex);
            return this.StatusCode(500);
        }
    }

    [HttpGet]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(int), StatusCodes.Status500InternalServerError)]
    public IActionResult Count()
    {
        try
        {
            var response = this.Ok(this.todoListDatabaseService.Count());
            this.logger.RequestSuccesfullyHandled();
            return response;
        }
        catch (DbException ex)
        {
            this.logger.DbThrewException(ex);
            return this.StatusCode(500);
        }
    }
}
