using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace MarketWatch.Simulation
{
    public class FundTradeHistoryAppServiceTests : MarketWatchApplicationTestBase
    {
        private readonly IFundTradeHistoryAppService _fundTradeHistoryAppService;

        public FundTradeHistoryAppServiceTests()
        {
            _fundTradeHistoryAppService = GetRequiredService<IFundTradeHistoryAppService>();
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
