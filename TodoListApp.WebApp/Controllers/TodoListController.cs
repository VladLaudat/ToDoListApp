using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TodoListApp.WebApp.Controllers.Logging;
using TodoListApp.WebApp.Models.RequestModels.TodoListControllerModels;
using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

    public async Task<IActionResult> List(ListActionRequestModel model)
    {
        if (!this.ModelState.IsValid || model == null)
        {
            this.logger.InvalidModel();
            return this.BadRequest(this.ModelState);
        }

        var viewmodel = await this.todoListWebApiService.List(model.Page);
        this.logger.RequestSuccesfullyHandled();
        return this.View(viewmodel);
    }

    public async Task<IActionResult> AddToDb(TodoListListViewModel)
    {
        return this.View();
    }

    public async Task<IActionResult> Edit([FromQuery] int id)
    {
        if (!this.ModelState.IsValid)
        {
            this.logger.InvalidModel();
            return this.BadRequest(this.ModelState);
        }

        var model = await this.todoListWebApiService.GetById(id);
        return this.View(model);
    }

    public async Task<IActionResult> DeleteFromDb(int id)
    {
        if (!this.ModelState.IsValid)
        {
            this.logger.InvalidModel();
            return this.RedirectToAction("List");
        }

        await this.todoListWebApiService.Delete(id);
        this.logger.RequestDeleteFromDb();
        return this.RedirectToAction("List");
    }

    public async Task<IActionResult> UpdateToDb(TodoListListViewModel todoListWebApiModel)
    {
        if (!this.ModelState.IsValid || todoListWebApiModel == null)
        {
            this.logger.InvalidModel();
            return this.RedirectToAction("List");
        }

        await this.todoListWebApiService.Update(todoListWebApiModel);
        this.logger.RequestUpdateFromDb();
        return this.RedirectToAction("List");
    }

    [NonAction]
    public Task AddToDb(TodoListListViewModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }
}
