using Volo.Abp.Modularity;

namespace MarketWatch
{
    [DependsOn(
        typeof(MarketWatchApplicationModule),
        typeof(MarketWatchDomainTestModule)
        )]
    public class MarketWatchApplicationTestModule : AbpModule
    {

    }
}