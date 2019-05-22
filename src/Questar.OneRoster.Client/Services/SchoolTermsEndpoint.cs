namespace Questar.OneRoster.Client.Services
{
    using Flurl.Http;
    using Models;

    public class SchoolTermsEndpoint : ListEndpoint<AcademicSession>
    {
        public SchoolTermsEndpoint(IFlurlClient http, string path) : base(http, path)
        {
        }
    }
}