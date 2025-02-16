namespace TodoListApp.WebApp.WebAPIServices.Logging;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public static class CommonLoggerExtensions
{
    private static readonly Action<ILogger, Type, Exception?> ListRequestSuccessful = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(ApiListRequestSuccessful)),
            "{Type} list retrieved from API");

    private static readonly Action<ILogger, Type, Exception?> RetrieveByIdRequestSuccessful = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(ApiRetieveByIdRequestSuccessful)),
            "{Type} retrieved by id from API");

    private static readonly Action<ILogger, Type, Exception?> DeleteRequestSuccessful = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(ApiDeleteRequestSuccessful)),
            "{Type} removed from API");

    private static readonly Action<ILogger, Type, Exception?> UpdateRequestSuccessful = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(ApiUpdateRequestSuccessful)),
            "{Type} updated to API");

    private static readonly Action<ILogger, Type, Exception?> AddRequestSuccessful = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(ApiAddRequestSuccessful)),
            "{Type} added to API");

    private static readonly Action<ILogger, Type, Exception?> CountRequestSuccessful = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(ApiCountRequestSuccessful)),
            "Retrieved number of records of {Type} from API");

    public static void ApiListRequestSuccessful<TModel>(this ILogger logger)
    {
        ListRequestSuccessful(logger, typeof(TModel), null);
    }

    public static void ApiRetieveByIdRequestSuccessful<TModel>(this ILogger logger)
    {
        RetrieveByIdRequestSuccessful(logger, typeof(TModel), null);
    }

    public static void ApiDeleteRequestSuccessful<TModel>(this ILogger logger)
    {
        DeleteRequestSuccessful(logger, typeof(TModel), null);
    }

    public static void ApiUpdateRequestSuccessful<TModel>(this ILogger logger)
    {
        UpdateRequestSuccessful(logger, typeof(TModel), null);
    }

    public static void ApiAddRequestSuccessful<TModel>(this ILogger logger)
    {
        AddRequestSuccessful(logger, typeof(TModel), null);
    }

    public static void ApiCountRequestSuccessful<TModel>(this ILogger logger)
    {
        CountRequestSuccessful(logger, typeof(TModel), null);
    }
}
