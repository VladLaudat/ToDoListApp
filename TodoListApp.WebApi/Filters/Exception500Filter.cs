using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

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

        if (context.Exception != null)
        {
            context.Result = new JsonResult("Unexpected error occurred") { StatusCode = 500 };
        }
    }
}
