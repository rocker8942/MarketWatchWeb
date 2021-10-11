using MarketWatch.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MarketWatch.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MarketWatchEntityFrameworkCoreModule),
        typeof(MarketWatchApplicationContractsModule)
        )]
    public class MarketWatchDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
