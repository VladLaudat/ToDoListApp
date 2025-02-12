using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApi.Controllers.Interfaces;
using TodoListApp.WebApi.Repository.Entities;
using TodoListApp.WebApi.Services.Interfaces;

namespace TodoListApp.WebApi.Controllers;

[Route("[controller]/[action]")]
[ApiController]
public class BaseController<TEntity, TController> : ControllerBase, ICrudController<TEntity>
    where TEntity : BaseEntity
    where TController : BaseController<TEntity, TController>
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S6672:Generic logger injection should match enclosing type", Justification = "Misfire")]
    public BaseController(IBaseDatabaseService<TEntity> service, ILogger<TController> logger)
    {
        this.Service = service;
        this.Logger = logger;
    }

    protected ILogger<TController> Logger { get; }

    protected IBaseDatabaseService<TEntity> Service { get; }

    [HttpGet]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public virtual IActionResult List([FromQuery] int page = 1, [FromQuery] int pageSize = 4)
    {
        var response = this.Service.Read(page, pageSize);
        return this.Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public IActionResult GetById([FromQuery] int id)
    {
        var response = this.Service.ReadById(id);
        return this.Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public IActionResult Add([FromBody] TEntity entity)
    {
        this.Service.Add(entity);
        return this.Ok();
    }

    [HttpDelete]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public IActionResult Delete([FromQuery] int id)
    {
        this.Service.Delete(id);
        return this.Ok();
    }

    [HttpPut]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public IActionResult Update([FromBody] TEntity entity)
    {
        this.Service.Update(entity);
        return this.Ok();
    }

    [HttpGet]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    public IActionResult Count()
    {
        var response = this.Service.Count();
        return this.Ok(response);
    }
}
