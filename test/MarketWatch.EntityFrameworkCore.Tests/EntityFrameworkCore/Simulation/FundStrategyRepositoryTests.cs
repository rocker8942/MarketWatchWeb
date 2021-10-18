using System;
using System.Threading.Tasks;
using MarketWatch.Simulation;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace MarketWatch.EntityFrameworkCore.Simulation
{
    public class FundStrategyRepositoryTests : MarketWatchEntityFrameworkCoreTestBase
    {
        private readonly IFundStrategyRepository _fundStrategyRepository;

        public FundStrategyRepositoryTests()
        {
            _fundStrategyRepository = GetRequiredService<IFundStrategyRepository>();
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
