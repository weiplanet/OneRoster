using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Questar.OneRoster.Api.Helpers;

namespace Questar.OneRoster.Api.Extensions
{
    public static class OneRosterApiMvcBuilderExtensions
    {
        public static IMvcBuilder AddOneRosterApi(this IMvcBuilder builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));
            builder.Services.AddHttpContextAccessor();
            builder.Services.TryAddSingleton<LinkHeaderFactory>();
            return builder
                .AddApplicationPart(Assembly.GetExecutingAssembly());
        }
    }
}