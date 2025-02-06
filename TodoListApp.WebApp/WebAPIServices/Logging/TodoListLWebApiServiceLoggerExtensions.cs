namespace TodoListApp.WebApp.WebAPIServices.Logging;

public static class TodoListLWebApiServiceLoggerExtensions
{
    private static readonly Action<ILogger, Exception?> TodoListsRetrieved = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(TodoListsRetrieved)),
            "Todo lists retrieved from API");

    private static readonly Action<ILogger, Exception?> TodoListRetrievedById = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RetrievedTodoListById)),
            "Todo list retrieved by id from API");

    private static readonly Action<ILogger, Exception?> UpdateSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(UpdatedTodoListSuccessfully)),
            "Update to API was successful");

    public static void RetrievedTodoLists(this ILogger logger)
    {
        TodoListsRetrieved(logger, null);
    }

    public static void RetrievedTodoListById(this ILogger logger)
    {
        TodoListRetrievedById(logger, null);
    }

    public static void UpdatedTodoListSuccessfully(this ILogger logger)
    {
        UpdateSuccessful(logger, null);
    }
}
