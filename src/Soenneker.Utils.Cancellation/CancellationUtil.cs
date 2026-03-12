using System.Threading;
using Soenneker.Utils.Cancellation.Abstract;

namespace Soenneker.Utils.Cancellation;

///<inheritdoc cref="ICancellationUtil"/>
public class CancellationUtil : ICancellationUtil
{
    private CancellationToken? _cancellationToken;

    public void Set(CancellationToken cancellationToken)
    {
        _cancellationToken = cancellationToken;
    }

    public CancellationToken Get()
    {
        CancellationToken result = _cancellationToken.GetValueOrDefault();
        return result;
    }
}