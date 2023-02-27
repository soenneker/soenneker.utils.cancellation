using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Utils.Cancellation.Abstract;

namespace Soenneker.Utils.Cancellation.Extensions;

public static class CancellationUtilRegistrar
{
    /// <summary>
    /// Adds ICancellationUtil as a scoped service. <para/>
    /// Shorthand for <code>services.AddScoped</code> <para/>
    /// </summary>
    public static void AddCancellationUtil(this IServiceCollection services)
    {
        services.TryAddScoped<ICancellationUtil, CancellationUtil>();
    }
}