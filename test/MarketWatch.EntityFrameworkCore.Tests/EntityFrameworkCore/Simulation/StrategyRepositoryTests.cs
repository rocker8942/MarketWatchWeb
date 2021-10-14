using System;
using System.Threading.Tasks;
using MarketWatch.Simulation;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MarketWatch.EntityFrameworkCore.Simulation
{
    public class StrategyRepositoryTests : MarketWatchEntityFrameworkCoreTestBase
    {
        private readonly IStrategyRepository _strategyRepository;

        public StrategyRepositoryTests()
        {
            _strategyRepository = GetRequiredService<IStrategyRepository>();
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
