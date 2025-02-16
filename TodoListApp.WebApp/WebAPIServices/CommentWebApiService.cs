using TodoListApp.WebApp.WebAPIServices.Helpers;
using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.WebAPIServices;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public class CommentWebApiService : GenericWebApiService<Comment, CommentWebApiService>
{
    public CommentWebApiService(IGenericServiceHelpers<Comment> helpers, HttpClient httpClient, ILogger<CommentWebApiService> logger)
        : base(helpers, httpClient, logger)
    {
    }
}
