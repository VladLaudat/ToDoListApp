using Microsoft.AspNetCore.Mvc;
using TodoListApp.WebApp.Controllers.Helpers;
using TodoListApp.WebApp.Controllers.Logging;
using TodoListApp.WebApp.Models.RequestModels.TaskControllerModels;
using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices.Interfaces;

namespace TodoListApp.WebApp.Controllers;
public class TaskController : Controller
{
    private readonly ITaskWebApiService taskWebApiService;
    private readonly ILogger<TaskController> logger;
    private readonly ITaskHelpers helpers;

    public TaskController(ITaskWebApiService taskWebApiService, ILogger<TaskController> logger, ITaskHelpers helpers)
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

        TaskListViewModel viewModel = new TaskListViewModel()
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
        throw new NotImplementedException();
    }

    public async Task<IActionResult> Edit()
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> DeleteFromDb()
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> UpdateToDb()
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResult> AddToDb()
    {
        throw new NotImplementedException();
    }


}
