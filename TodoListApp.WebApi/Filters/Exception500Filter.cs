using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using TodoListApp.WebApi.Controllers.Logging;

namespace TodoListApp.WebApi.Filters;

public class Exception500Filter : IExceptionFilter
{
    private readonly ILogger<Exception500Filter> logger;

    public Exception500Filter(ILogger<Exception500Filter> logger)
    {
        this.logger = logger;
    }

    public void OnException(ExceptionContext context)
    {
        ArgumentNullException.ThrowIfNull(context);

        if (context.Exception == null)
        {
            return;
        }

        var controller = context.RouteData.Values["controller"]?.ToString();
        var action = context.RouteData.Values["action"]?.ToString();

        this.logger.UnexpectedExceptionThrown(controller!, action!, context.Exception);
        context.Result = new JsonResult("Unexpected error occurred") { StatusCode = 500 };
    }
}
