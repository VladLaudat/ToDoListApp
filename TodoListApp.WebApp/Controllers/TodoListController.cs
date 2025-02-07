using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TodoListApp.WebApp.Controllers.Helpers;
using TodoListApp.WebApp.Controllers.Logging;
using TodoListApp.WebApp.Models.RequestModels.TodoListControllerModels;
using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace TodoListApp.WebApp.Controllers;
public class TodoListController : Controller
{
    private readonly ITodoListWebApiService todoListWebApiService;
    private readonly ILogger<TodoListController> logger;
    private readonly Helpers.ITodoListHelpers helpers;

    public TodoListController(ITodoListWebApiService todoListWebApiService, ILogger<TodoListController> logger, Helpers.ITodoListHelpers helpers)
    {
        this.todoListWebApiService = todoListWebApiService;
        this.logger = logger;
        this.helpers = helpers;
    }

    public async Task<IActionResult> List(ListActionRequestModel model)
    {
        if (!this.ModelState.IsValid || model == null)
        {
            this.logger.InvalidModel();
            return this.BadRequest(this.ModelState);
        }

        TodoListListViewModel viewmodel = new TodoListListViewModel
        {
            TodoLists = await this.todoListWebApiService.List(model.Page),
            TotalPages = await this.helpers.TotalPages(),
            CurrentPage = model.Page,
        };

        this.logger.RequestSuccesfullyHandled();
        return this.View(viewmodel);
    }

    public async Task<IActionResult> Add()
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

    public async Task<IActionResult> UpdateToDb(TodoListViewModel todoListWebApiModel)
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

    public async Task<IActionResult> AddToDb(TodoListViewModel todoListWebApiModel)
    {
        if (!this.ModelState.IsValid || todoListWebApiModel == null)
        {
            this.logger.InvalidModel();
            return this.RedirectToAction("List");
        }

        await this.todoListWebApiService.Add(todoListWebApiModel);
        this.logger.RequestCreateToDb();
        return this.RedirectToAction("List");
    }
}
