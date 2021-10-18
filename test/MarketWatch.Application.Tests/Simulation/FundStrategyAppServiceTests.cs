using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MarketWatch.Simulation
{
    public class FundStrategyAppServiceTests : MarketWatchApplicationTestBase
    {
        private readonly IFundStrategyAppService _fundStrategyAppService;

        public FundStrategyAppServiceTests()
        {
            _fundStrategyAppService = GetRequiredService<IFundStrategyAppService>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            // Arrange

            // Act

            // Assert
        }
        */
    }
}
