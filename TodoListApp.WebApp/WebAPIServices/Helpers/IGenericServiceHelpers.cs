namespace TodoListApp.WebApp.WebAPIServices.Helpers;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Code Smell", "S2326:Unused type parameters should be removed", Justification = "Needed for DI")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("Maintainability", "CA1515:Consider making public types internal", Justification = "I prefer public")]
[System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "I need the suppression")]
public interface IGenericServiceHelpers<TModel>
{
    public Uri UpdateEndpointUriGenerator();

    public Uri AddEndpointUriGenerator();

    public Uri DeleteEndpointUriGenerator(int id);

    Uri ListEndpointUriGenerator(int page);

    Uri GetByIdEndpointUriGenerator(int id);

    public Uri CountEndpointUriGenerator();
}
