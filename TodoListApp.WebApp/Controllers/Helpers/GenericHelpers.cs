using TodoListApp.WebApp.WebAPIServices.Interfaces;
using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.Controllers.Helpers;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public class GenericHelpers<TModel> : IGenericHelpers<TModel>
    where TModel : BaseModel
{
    private readonly IConfiguration configuration;
    private readonly IGenericWebApiSerice<TModel> webApiService;

    public GenericHelpers(IConfiguration configuration, IGenericWebApiSerice<TModel> webApiService)
    {
        this.configuration = configuration;
        this.webApiService = webApiService;
    }

    public async Task<int> TotalPages()
    {
        var count = await this.webApiService.Count();

        if (int.TryParse(this.configuration["Constants:ListingEndpointsPageSize"], out int listPageSize))
        {
            decimal pages = Math.Ceiling((decimal)count / listPageSize);
            return (int)pages;
        }

        return 0;
    }
}
