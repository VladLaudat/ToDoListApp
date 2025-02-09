namespace TodoListApp.WebApi.Services.Logging;

public static class TaskDatabaseServiceLoggerExtensions
{
    private static readonly Action<ILogger, Exception?> TasksRetrieved = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RetrievedTasks)),
            "Todo lists retrieved from database");

    private static readonly Action<ILogger, Exception?> TaskRetrievedById = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RetrievedTaskById)),
            "Todo list retrieved by id from database");

    private static readonly Action<ILogger, Exception?> TaskRemoved = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RemovedTask)),
            "Todo list removed from database");

    private static readonly Action<ILogger, Exception?> TaskEdited = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(EditedTask)),
            "Todo list edited in database");

    private static readonly Action<ILogger, Exception?> TaskAdded = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(AddedTask)),
            "Todo list added to database");

    private static readonly Action<ILogger, Exception?> TaskCounted = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(CountedTasks)),
            "Retrieved number of records from TodoList");

    public static void RetrievedTasks(this ILogger logger)
    {
        TasksRetrieved(logger, null);
    }

    public static void RetrievedTaskById(this ILogger logger)
    {
        TaskRetrievedById(logger, null);
    }

    public static void RemovedTask(this ILogger logger)
    {
        TaskRemoved(logger, null);
    }

    public static void EditedTask(this ILogger logger)
    {
        TaskEdited(logger, null);
    }

    public static void AddedTask(this ILogger logger)
    {
        TaskAdded(logger, null);
    }

    public static void CountedTasks(this ILogger logger)
    {
        TaskCounted(logger, null);
    }
}
