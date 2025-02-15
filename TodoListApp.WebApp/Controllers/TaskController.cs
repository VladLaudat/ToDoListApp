using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApp.Controllers.Helpers;
using TodoListApp.WebApp.Controllers.Logging;
using TodoListApp.WebApp.Models.RequestModels.TaskControllerModels;
using TodoListApp.WebApp.ViewModels.Task;
using TodoListApp.WebApp.WebAPIServices;
using TodoListApp.WebApp.WebAPIServices.Interfaces;
using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.Controllers;
public class TaskController : Controller
{
    private readonly IGenericWebApiSerice<WebAPIServices.Models.Task> taskWebApiService;
    private readonly ILogger<TaskController> logger;
    private readonly IGenericHelpers<WebAPIServices.Models.Task> helpers;

    public TaskController(IGenericWebApiSerice<WebAPIServices.Models.Task> taskWebApiService, ILogger<TaskController> logger, IGenericHelpers<WebAPIServices.Models.Task> helpers)
    {
        this.taskWebApiService = taskWebApiService;
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

        ListViewModel viewModel = new ListViewModel()
        {
            Tasks = await this.taskWebApiService.List(model.Page),
            TotalPages = await this.helpers.TotalPages(),
            CurrentPage = model.Page,
        };

        this.logger.RequestSuccesfullyHandled();
        return this.View(viewModel);
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

        var model = await this.taskWebApiService.GetById(id);
        return this.View(model);
    }

    public async Task<IActionResult> DeleteFromDb(int id)
    {
        if (!this.ModelState.IsValid)
        {
            this.logger.InvalidModel();
            return this.RedirectToAction("List");
        }

        await this.taskWebApiService.Delete(id);
        this.logger.RequestDeleteFromDb();
        return this.RedirectToAction("List");
    }

    public async Task<IActionResult> UpdateToDb(WebAPIServices.Models.Task taskWebApiModel)
    {
        if (!this.ModelState.IsValid || taskWebApiModel == null)
        {
            this.logger.InvalidModel();
            return this.RedirectToAction("List");
        }

        await this.taskWebApiService.Update(taskWebApiModel);
        this.logger.RequestUpdateFromDb();
        return this.RedirectToAction("List");
    }

    public async Task<IActionResult> AddToDb(WebAPIServices.Models.Task taskWebApiModel)
    {
        if (!this.ModelState.IsValid || taskWebApiModel == null)
        {
            this.logger.InvalidModel();
            return this.RedirectToAction("List");
        }

        await this.taskWebApiService.Add(taskWebApiModel);
        this.logger.RequestCreateToDb();
        return this.RedirectToAction("List");
    }

    public async Task<IActionResult> Details([FromQuery] int id)
    {
        if (!this.ModelState.IsValid)
        {
            this.logger.InvalidModel();
            return this.RedirectToAction("List");
        }

        var model = await this.taskWebApiService.GetById(id);
        return this.View(model);
    }

}
