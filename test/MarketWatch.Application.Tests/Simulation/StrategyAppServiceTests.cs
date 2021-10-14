using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MarketWatch.Simulation
{
    public class StrategyAppServiceTests : MarketWatchApplicationTestBase
    {
        private readonly IStrategyAppService _strategyAppService;

        public StrategyAppServiceTests()
        {
            _strategyAppService = GetRequiredService<IStrategyAppService>();
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
