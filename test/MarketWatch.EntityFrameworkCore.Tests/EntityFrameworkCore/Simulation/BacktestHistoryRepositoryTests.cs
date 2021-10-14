using System;
using System.Threading.Tasks;
using MarketWatch.Simulation;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MarketWatch.EntityFrameworkCore.Simulation
{
    public class BacktestHistoryRepositoryTests : MarketWatchEntityFrameworkCoreTestBase
    {
        private readonly IBacktestHistoryRepository _backtestHistoryRepository;

        public BacktestHistoryRepositoryTests()
        {
            _backtestHistoryRepository = GetRequiredService<IBacktestHistoryRepository>();
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
