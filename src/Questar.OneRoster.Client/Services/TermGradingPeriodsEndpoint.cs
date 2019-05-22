namespace Questar.OneRoster.Client.Services
{
    using Flurl.Http;
    using Models;

    public class TermGradingPeriodsEndpoint : ListEndpoint<AcademicSession>
    {
        public TermGradingPeriodsEndpoint(IFlurlClient http, string path) : base(http, path)
        {
        }
    }
}