namespace TodoListApp.WebApi.Services.Logging;

public static class TodoListDatabaseServiceLoggerExtensions
{
    private static readonly Action<ILogger, Exception?> TodoListsRetrieved = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(TodoListsRetrieved)),
            "Todo lists retrieved from database");

    public static void RetrievedTodoLists(this ILogger logger)
    {
        TodoListsRetrieved(logger, null);
    }
}
