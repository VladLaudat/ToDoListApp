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
public class TodoListController : BaseController<TodoListEntity, TodoListController>
{
    public TodoListController(IBaseDatabaseService<TodoListEntity> todoListDatabaseService, ILogger<TodoListController> logger)
        : base(todoListDatabaseService, logger)
    {
    }

    /*[HttpGet]
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
    public IActionResult Add(TodoListEntity entity)
    {
        try
        {
            this.todoListDatabaseService.Add(entity);
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
    public IActionResult Update(TodoListEntity entity)
    {
        try
        {
            this.todoListDatabaseService.Update(entity);
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
    }*/
}
