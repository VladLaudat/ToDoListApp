namespace TodoListApp.WebApp.Controllers.Logging;

public static class CommonControllerLoggerExtensions
{
    private static readonly Action<ILogger, Exception?> RequestSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RequestSuccesfullyHandled)),
            "Request has been successfully handled");

    private static readonly Action<ILogger, Exception?> ModelInvalid = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(InvalidModel)),
            "The model was invalid");

    public static void RequestSuccesfullyHandled(this ILogger logger)
    {
        RequestSuccessful(logger, null);
    }

    public static void InvalidModel(this ILogger logger)
    {
        ModelInvalid(logger, null);
    }
}
