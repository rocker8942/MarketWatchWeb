using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MarketWatch.Simulation
{
    public class BacktestHistoryAppServiceTests : MarketWatchApplicationTestBase
    {
        private readonly IBacktestHistoryAppService _backtestHistoryAppService;

        public BacktestHistoryAppServiceTests()
        {
            _backtestHistoryAppService = GetRequiredService<IBacktestHistoryAppService>();
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
