using System.Diagnostics.Contracts;
using System.Threading;

namespace Soenneker.Utils.Cancellation.Abstract;

/// <summary>
/// A utility library allowing for easy CancellationToken usage <para/>
/// MUST be Scoped IoC
/// </summary>
public interface ICancellationUtil
{
    void Set(CancellationToken cancellationToken);

    /// <summary>
    /// This is not nullable for ease of use.
    /// </summary>
    /// <returns>Not guaranteed to return non-null (default) if it has never been set before calling this method</returns>
    [Pure]
    CancellationToken Get();
}