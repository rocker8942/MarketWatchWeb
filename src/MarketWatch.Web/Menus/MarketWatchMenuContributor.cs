using System.Threading.Tasks;
using MarketWatch.Permissions;
using MarketWatch.Localization;
using MarketWatch.MultiTenancy;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace MarketWatch.Web.Menus
{
    public class MarketWatchMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var administration = context.Menu.GetAdministration();
            var l = context.GetLocalizer<MarketWatchResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    MarketWatchMenus.Home,
                    l["Menu:Home"],
                    "~/",
                    icon: "fas fa-home",
                    order: 0
                )
            );
            
            if (MultiTenancyConsts.IsEnabled)
            {
                administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
            }
            else
            {
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
            administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);
            if (await context.IsGrantedAsync(MarketWatchPermissions.Strategy.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(MarketWatchMenus.Strategy, l["Menu:Strategy"], "/Simulation/Strategy")
                );
            }
            if (await context.IsGrantedAsync(MarketWatchPermissions.BacktestHistory.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(MarketWatchMenus.BacktestHistory, l["Menu:BacktestHistory"], "/Simulation/BacktestHistory")
                );
            }
            if (await context.IsGrantedAsync(MarketWatchPermissions.FundTradeHistory.Default))
            {
                context.Menu.AddItem(
                    new ApplicationMenuItem(MarketWatchMenus.FundTradeHistory, l["Menu:FundTradeHistory"], "/Simulation/FundTradeHistory")
                );
            }
        }
    }
}
