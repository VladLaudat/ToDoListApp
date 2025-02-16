namespace TodoListApp.WebApp.Controllers.Logging;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
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
