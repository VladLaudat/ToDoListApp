using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TodoListApp.WebApi.Controllers.Logging;

namespace TodoListApp.WebApi.Filters;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
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
