namespace Questar.OneRoster.ApiClient.Services
{
    using Flurl.Http;
    using Models;

    public class ClassResultsEndpoint : ListEndpoint<Result>
    {
        public ClassResultsEndpoint(IFlurlClient http, string path) : base(http, path)
        {
        }
    }
}