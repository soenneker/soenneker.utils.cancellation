using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Soenneker.Utils.Cancellation.Abstract;
using Soenneker.Tests.HostedUnit;


namespace Soenneker.Utils.Cancellation.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class CancellationUtilTests : HostedUnitTest
{
    private readonly ICancellationUtil _util;

    public CancellationUtilTests(Host host) : base(host)
    {
        _util = Resolve<ICancellationUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
