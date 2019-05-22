namespace Questar.OneRoster.Client.Services
{
    using Flurl.Http;
    using Models;

    public class OrgEndpoint : ItemEndpoint<Org>
    {
        public OrgEndpoint(IFlurlClient http, string path) : base(http, path)
        {
        }
    }
}