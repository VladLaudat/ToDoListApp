using System.Data.Common;

namespace TodoListApp.WebApp.Controllers.Logging;

public static class TodoListControllerLoggerExtensions
{
    private static readonly Action<ILogger, Exception?> RequestSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RequestSuccesfullyHandled)),
            "Request has been successfully handled");

    private static readonly Action<ILogger, Exception?> ModelInvalid = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(InvalidModel)),
            "The model was invalid");

    private static readonly Action<ILogger, Exception?> RequestDeleteTodoList = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RequestDeleteFromDb)),
            "A request to delete a to do list from the database was made");

    private static readonly Action<ILogger, Exception?> RequestUpdateTodoList = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RequestUpdateFromDb)),
            "A request to update a to do list from the database was made");

    private static readonly Action<ILogger, Exception?> RequestCreateTodoList = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RequestCreateToDb)),
            "A request to create a to do list to the database was made");

    public static void RequestSuccesfullyHandled(this ILogger logger)
    {
        RequestSuccessful(logger, null);
    }

    public static void InvalidModel(this ILogger logger)
    {
        ModelInvalid(logger, null);
    }

    public static void RequestDeleteFromDb(this ILogger logger)
    {
        RequestDeleteTodoList(logger, null);
    }

    public static void RequestUpdateFromDb(this ILogger logger)
    {
        RequestUpdateTodoList(logger, null);
    }

    public static void RequestCreateToDb(this ILogger logger)
    {
        RequestCreateTodoList(logger, null);
    }
}
