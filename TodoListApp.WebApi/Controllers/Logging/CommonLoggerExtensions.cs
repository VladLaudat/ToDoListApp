using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using TodoListApp.WebApi.Controllers.Interfaces;

namespace TodoListApp.WebApi.Controllers.Logging;

public static class CommonLoggerExtensions
{
    private static readonly Action<ILogger, string, string, Exception?> UnexpectedException = LoggerMessage.Define<string, string>(
            LogLevel.Warning,
            new EventId(0, nameof(UnexpectedExceptionThrown)),
            "Unexpected exception thrown in controller : {Controller}, action : {Action}");

    private static readonly Action<ILogger, string, string, Exception?> ValidationException = LoggerMessage.Define<string, string>(
            LogLevel.Warning,
            new EventId(0, nameof(ValidationExceptionThrown)),
            "Validation exception thrown in controller : {Controller}, action : {Action}");

    private static readonly Action<ILogger, string, string, Exception?> RequestSuccessful = LoggerMessage.Define<string, string>(
            LogLevel.Information,
            new EventId(0, nameof(RequestSuccesfullyHandled)),
            "Request has been successfully handled in controller : {Controller}, action : {Action}");

    public static void ValidationExceptionThrown(this ILogger logger, string controller, string action, Exception exception)
    {
        ValidationException(logger, controller, action, exception);
    }

    public static void RequestSuccesfullyHandled(this ILogger logger, string controller, string action)
    {
        RequestSuccessful(logger, controller, action, null);
    }

    public static void UnexpectedExceptionThrown(this ILogger logger, string controller, string action, Exception exception)
    {
        UnexpectedException(logger, controller, action, exception);
    }
}
