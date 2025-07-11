using Blaze.Core;
using Blaze.Hosting.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Blaze.Hosting.Extensions;

public static class BlazeServicesExtensions
{

    public static IServiceCollection AddBlazeContext<TCtx>(this IServiceCollection services, Action<BlazeServerContextOptions, IServiceProvider> configure) where TCtx : BlazeServerContext
    {
        // check if such a context is already registered
        if (services.Any(d => d.ServiceType == typeof(BlazeServerContext) && d.ImplementationType == typeof(TCtx)))
            return services;

        services.AddSingleton<TCtx>();
        services.AddSingleton<BlazeServerContext, TCtx>(provider => provider.GetRequiredService<TCtx>());
        services.AddKeyedSingleton<Action<BlazeServerContextOptions, IServiceProvider>>(typeof(TCtx), configure);

        // Register the blaze background service only once
        if (!services.Any(d => d.ServiceType == typeof(IHostedService) && d.ImplementationType == typeof(BlazeBackgroundService)))
            services.AddHostedService<BlazeBackgroundService>();

        return services;
    }

}
