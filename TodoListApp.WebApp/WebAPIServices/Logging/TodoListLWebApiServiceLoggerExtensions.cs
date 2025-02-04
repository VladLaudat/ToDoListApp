namespace TodoListApp.WebApp.WebAPIServices.Logging;

public static class TodoListLWebApiServiceLoggerExtensions
{
    private static readonly Action<ILogger, Exception?> TodoListsRetrieved = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(TodoListsRetrieved)),
            "Todo lists retrieved from API");

    public static void RetrievedTodoLists(this ILogger logger)
    {
        TodoListsRetrieved(logger, null);
    }
}
