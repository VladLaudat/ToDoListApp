using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TodoListApp.WebApp.ViewModels;
using TodoListApp.WebApp.WebAPIServices.Interfaces;

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

    public async Task<IActionResult> List([FromQuery] int page = 1)
    {
        if (!this.ModelState.IsValid)
        {
            this.logger.LogInformation("Model is invalid: ", this.ModelState.ValidationState);
            return this.BadRequest(this.ModelState);
        }

        var model = await this.todoListWebApiService.List(page);
        this.logger.LogInformation("Request succesfully handled", this.ModelState.ValidationState);
        return this.View(model);
    }

    public IActionResult Add(TodoListListViewModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }

    public IActionResult Delete(TodoListListViewModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }

    public IActionResult Update(TodoListListViewModel todoListWebApiModel)
    {
        throw new NotImplementedException();
    }
}
