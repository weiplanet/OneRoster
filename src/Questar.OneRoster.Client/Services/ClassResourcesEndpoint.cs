namespace Questar.OneRoster.Client.Services
{
    using Flurl.Http;
    using Models;

    public class ClassResourcesEndpoint : ListEndpoint<Resource>
    {
        public ClassResourcesEndpoint(IFlurlClient http, string path) : base(http, path)
        {
        }
    }
}