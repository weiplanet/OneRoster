using System;
using System.Reflection;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using AutoMapper.Extensions.ExpressionMapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Questar.OneRoster.Data.Services;
using Questar.OneRoster.DataServices;

namespace Questar.OneRoster.Data.Extensions
{
    public static class OneRosterServiceCollectionExtensions
    {
        public static void AddOneRoster(this IServiceCollection services, string connectionString)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddDbContext<OneRosterDbContext>(options => { options.UseSqlServer(connectionString); });
            services.AddAutoMapper(config =>
            {
                config.AddExpressionMapping();
                config.AddCollectionMappers();
            }, Assembly.GetExecutingAssembly());
            services.AddScoped<OneRosterDbContext>();
            services.AddScoped<IOneRosterWorkspace, OneRosterWorkspace>();
        }
    }
}