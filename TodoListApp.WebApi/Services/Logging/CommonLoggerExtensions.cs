namespace TodoListApp.WebApi.Services.Logging;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public static class CommonLoggerExtensions
{
    private static readonly Action<ILogger, Type, Exception?> EntityRetrieved = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(DBRetrievedEntities)),
            "{Type} retrieved from database");

    private static readonly Action<ILogger, Type, Exception?> EntityRetrievedById = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(DBRetrievedEntitiesById)),
            "{Type} retrieved by id from database");

    private static readonly Action<ILogger, Type, Exception?> EntityRemoved = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(DBRemovedEntities)),
            "{Type} removed from database");

    private static readonly Action<ILogger, Type, Exception?> EntityEdited = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(DBEditedEntities)),
            "{Type} edited in database");

    private static readonly Action<ILogger, Type, Exception?> EntityAdded = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(DBAddedEntities)),
            "{Type} added to database");

    private static readonly Action<ILogger, Type, Exception?> EntityCounted = LoggerMessage.Define<Type>(
            LogLevel.Information,
            new EventId(0, nameof(DBCountedEntities)),
            "Retrieved number of records from {Type}");

    public static void DBRetrievedEntities<TEntity>(this ILogger logger)
    {
        EntityRetrieved(logger, typeof(TEntity), null);
    }

    public static void DBRetrievedEntitiesById<TEntity>(this ILogger logger)
    {
        EntityRetrievedById(logger, typeof(TEntity), null);
    }

    public static void DBRemovedEntities<TEntity>(this ILogger logger)
    {
        EntityRemoved(logger, typeof(TEntity), null);
    }

    public static void DBEditedEntities<TEntity>(this ILogger logger)
    {
        EntityEdited(logger, typeof(TEntity), null);
    }

    public static void DBAddedEntities<TEntity>(this ILogger logger)
    {
        EntityAdded(logger, typeof(TEntity), null);
    }

    public static void DBCountedEntities<TEntity>(this ILogger logger)
    {
        EntityCounted(logger, typeof(TEntity), null);
    }
}
