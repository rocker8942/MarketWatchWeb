using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MarketWatch.Web
{
    [Dependency(ReplaceServices = true)]
    public class MarketWatchBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MarketWatch";
    }
}
