using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Soenneker.Utils.Cancellation.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;


namespace Soenneker.Utils.Cancellation.Tests;

[Collection("Collection")]
public class CancellationUtilTests : FixturedUnitTest
{
    private readonly ICancellationUtil _util;

    public CancellationUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<ICancellationUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
