namespace TodoListApp.WebApp.Controllers.Logging;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public static class TodoListControllerLoggerExtensions
{
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
