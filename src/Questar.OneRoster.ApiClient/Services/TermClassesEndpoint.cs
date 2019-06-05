using Flurl.Http;
using Questar.OneRoster.Models;

namespace Questar.OneRoster.ApiClient.Services
{
    public class TermClassesEndpoint : ListEndpoint<Class>
    {
        public TermClassesEndpoint(IFlurlClient http, string path) : base(http, path)
        {
        }
    }
}