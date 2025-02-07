namespace TodoListApp.WebApp.WebAPIServices.Logging;

public static class TaskWebApiServiceLoggerExtensions
{
    private static readonly Action<ILogger, Exception?> TasksRetrieved = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RetrievedTasks)),
            "Tasks retrieved from API");

    private static readonly Action<ILogger, Exception?> TaskRetrievedById = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(RetrievedTaskById)),
            "Task retrieved by id from API");

    private static readonly Action<ILogger, Exception?> UpdateSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(UpdatedTaskSuccessfully)),
            "Update to API was successful");

    private static readonly Action<ILogger, Exception?> AddSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(AddedTaskSuccessfully)),
            "Add to API was successful");

    private static readonly Action<ILogger, Exception?> DeleteSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(DeletedTaskSuccessfully)),
            "Delete to API was successful");

    private static readonly Action<ILogger, Exception?> CountSuccessful = LoggerMessage.Define(
            LogLevel.Information,
            new EventId(0, nameof(CountedTaskSuccessfully)),
            "Count from API was successful");

    public static void RetrievedTasks(this ILogger logger)
    {
        TasksRetrieved(logger, null);
    }

    public static void RetrievedTaskById(this ILogger logger)
    {
        TaskRetrievedById(logger, null);
    }

    public static void UpdatedTaskSuccessfully(this ILogger logger)
    {
        UpdateSuccessful(logger, null);
    }

    public static void AddedTaskSuccessfully(this ILogger logger)
    {
        AddSuccessful(logger, null);
    }

    public static void DeletedTaskSuccessfully(this ILogger logger)
    {
        DeleteSuccessful(logger, null);
    }

    public static void CountedTaskSuccessfully(this ILogger logger)
    {
        CountSuccessful(logger, null);
    }
}
