namespace TodoListApp.WebApi.Services.Logging;

public static class TodoListDatabaseServiceLoggerExtensions
{
    private static readonly Action<ILogger, Exception?> TodoListsRetrieved = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(TodoListsRetrieved)),
            "Todo lists retrieved from database");

    private static readonly Action<ILogger, Exception?> TodoListRetrievedById = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RetrievedTodoListById)),
            "Todo list retrieved by id from database");

    private static readonly Action<ILogger, Exception?> TodoListRemoved = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RemovedTodoList)),
            "Todo list removed from database");

    private static readonly Action<ILogger, Exception?> TodoListEdited = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(EditedTodoList)),
            "Todo list edited in database");

    private static readonly Action<ILogger, Exception?> TodoListAdded = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(AddedTodoList)),
            "Todo list added to database");

    public static void RetrievedTodoLists(this ILogger logger)
    {
        TodoListsRetrieved(logger, null);
    }

    public static void RetrievedTodoListById(this ILogger logger)
    {
        TodoListRetrievedById(logger, null);
    }

    public static void RemovedTodoList(this ILogger logger)
    {
        TodoListRemoved(logger, null);
    }

    public static void EditedTodoList(this ILogger logger)
    {
        TodoListEdited(logger, null);
    }

    public static void AddedTodoList(this ILogger logger)
    {
        TodoListAdded(logger, null);
    }
}
