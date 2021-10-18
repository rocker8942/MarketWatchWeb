using System;
using System.Threading.Tasks;
using MarketWatch.Simulation;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MarketWatch.EntityFrameworkCore.Simulation
{
    public class FundTradeHistoryRepositoryTests : MarketWatchEntityFrameworkCoreTestBase
    {
        private readonly IFundTradeHistoryRepository _fundTradeHistoryRepository;

        public FundTradeHistoryRepositoryTests()
        {
            _fundTradeHistoryRepository = GetRequiredService<IFundTradeHistoryRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
