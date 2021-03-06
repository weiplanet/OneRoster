namespace Questar.OneRoster.Data.Extensions
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Services;

    public static class OneRosterApplicationBuilderExtensions
    {
        public static void UseOneRoster(this IApplicationBuilder app, bool initialize = false)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            using (var context = scope.ServiceProvider.GetService<OneRosterDbContext>())
            {
                context.Database.Migrate();

                if (initialize) new OneRosterDbContextInitializer(context).Initialize();
            }
        }
    }
}