using System.Data.Common;

namespace TodoListApp.WebApi.Controllers.Logging;

public static class CommonControllerLoggerExtensions
{
    private static readonly Action<ILogger, Type, Exception?> UnexpectedException = LoggerMessage.Define<Type>(
            LogLevel.Critical,
            new EventId(0, nameof(UnexpectedExceptionThrown)),
            "Unexpected exception thrown in controller {Type}");

    private static readonly Action<ILogger, Exception?> DbException = LoggerMessage.Define(
            LogLevel.Critical,
            new EventId(0, nameof(DbException)),
            "Database exception thrown");

    private static readonly Action<ILogger, Exception?> RequestSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RequestSuccesfullyHandled)),
            "Request has been successfully handled");

    public static void DbThrewException(this ILogger logger, DbException dbException)
    {
        DbException(logger, dbException);
    }

    public static void RequestSuccesfullyHandled(this ILogger logger)
    {
        RequestSuccessful(logger, null);
    }

    public static void UnexpectedExceptionThrown(this ILogger logger, Type controller, Exception exception)
    {
        UnexpectedException(logger, controller, exception);
    }
}
