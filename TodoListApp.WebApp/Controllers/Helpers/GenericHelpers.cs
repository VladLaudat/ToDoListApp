using TodoListApp.WebApp.WebAPIServices.Interfaces;
using TodoListApp.WebApp.WebAPIServices.Models;

namespace TodoListApp.WebApp.Controllers.Helpers;

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
