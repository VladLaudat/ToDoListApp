namespace TodoListApp.WebApi.Controllers.Logging;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
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
