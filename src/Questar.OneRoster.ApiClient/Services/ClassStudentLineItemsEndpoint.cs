using Flurl.Http;
using Questar.OneRoster.Models;

namespace Questar.OneRoster.ApiClient.Services
{
    public class ClassStudentLineItemsEndpoint : ListEndpoint<LineItem>
    {
        public ClassStudentLineItemsEndpoint(IFlurlClient http, string path) : base(http, path)
        {
        }
    }
}