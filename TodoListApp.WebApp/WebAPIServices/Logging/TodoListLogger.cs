namespace TodoListApp.WebApp.WebAPIServices.Logging;

public static class TodoListLogger
{
    private static readonly Action<ILogger, Exception?> TodoListsRetrieved;

    static TodoListLogger()
    {
        TodoListsRetrieved = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(TodoListsRetrieved)),
            "Todo lists retrieved");
    }

    public static void RetrievedTodoLists(this ILogger logger)
    {
        TodoListsRetrieved(logger, null);
    }
}
