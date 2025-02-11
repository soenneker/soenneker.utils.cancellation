using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Utils.Cancellation.Abstract;

namespace Soenneker.Utils.Cancellation.Registrars;

/// <summary>
/// A utility library allowing for easy CancellationToken usage
/// </summary>
public static class CancellationUtilRegistrar
{
    /// <summary>
    /// Adds ICancellationUtil as a scoped service. <para/>
    /// Shorthand for <code>services.TryAddScoped</code> <para/>
    /// </summary>
    public static IServiceCollection AddCancellationUtil(this IServiceCollection services)
    {
        services.TryAddScoped<ICancellationUtil, CancellationUtil>();
        return services;
    }
}