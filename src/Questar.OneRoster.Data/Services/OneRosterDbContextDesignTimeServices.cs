namespace Questar.OneRoster.Data.Services
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.DependencyInjection;

    internal class OneRosterDbContextDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection services)
        {
            services.AddIdentity<User, Role>().AddDefaultTokenProviders();
        }
    }
}