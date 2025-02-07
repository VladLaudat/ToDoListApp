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

    private static readonly Action<ILogger, Exception?> AddSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(AddedTodoListSuccessfully)),
            "Update to API was successful");

    private static readonly Action<ILogger, Exception?> DeleteSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(DeletedTodoListSuccessfully)),
            "Delete to API was successful");

    private static readonly Action<ILogger, Exception?> CountSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(CountedTodoListSuccessfully)),
            "Count from API was successful");

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

    public static void AddedTodoListSuccessfully(this ILogger logger)
    {
        AddSuccessful(logger, null);
    }

    public static void DeletedTodoListSuccessfully(this ILogger logger)
    {
        DeleteSuccessful(logger, null);
    }

    public static void CountedTodoListSuccessfully(this ILogger logger)
    {
        CountSuccessful(logger, null);
    }
}
