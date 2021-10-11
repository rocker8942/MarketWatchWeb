using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MarketWatch.Data;
using Volo.Abp.DependencyInjection;

namespace MarketWatch.EntityFrameworkCore
{
    public class EntityFrameworkCoreMarketWatchDbSchemaMigrator
        : IMarketWatchDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMarketWatchDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MarketWatchDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MarketWatchDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
