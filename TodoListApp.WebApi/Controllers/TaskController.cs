using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApi.Controllers.Logging;
using TodoListApp.WebApi.Models;
using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Controllers;
[Route("[controller]/[action]")]
[ApiController]
public class TaskController : ControllerBase
{
    private readonly ILogger<TaskController> logger;
    private readonly IBaseDatabaseService<TaskEntity> taskDatabaseService;

    public TaskController(IBaseDatabaseService<TaskEntity> taskDatabaseService, ILogger<TaskController> logger)
    {
        this.taskDatabaseService = taskDatabaseService;
        this.logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(int), StatusCodes.Status500InternalServerError)]
    public IActionResult Get([FromQuery] int page = 1, [FromQuery] int pageSize = 4)
    {
        try
        {
            var response = this.Ok(this.taskDatabaseService.Read(page, pageSize));
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
            var response = this.Ok(this.taskDatabaseService.ReadById(id));
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
    public IActionResult Add(TaskEntity entity)
    {
        try
        {
            this.taskDatabaseService.Add(entity);
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
            this.taskDatabaseService.Delete(id);
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
    public IActionResult Update(TaskEntity entity)
    {
        try
        {
            this.taskDatabaseService.Update(entity);
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
            var response = this.Ok(this.taskDatabaseService.Count());
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
