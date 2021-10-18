using MarketWatch.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MarketWatch.Permissions
{
    public class MarketWatchPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(MarketWatchPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(MarketWatchPermissions.MyPermission1, L("Permission:MyPermission1"));

            var strategyPermission = myGroup.AddPermission(MarketWatchPermissions.Strategy.Default, L("Permission:Strategy"));
            strategyPermission.AddChild(MarketWatchPermissions.Strategy.Create, L("Permission:Create"));
            strategyPermission.AddChild(MarketWatchPermissions.Strategy.Update, L("Permission:Update"));
            strategyPermission.AddChild(MarketWatchPermissions.Strategy.Delete, L("Permission:Delete"));

            var backtestHistoryPermission = myGroup.AddPermission(MarketWatchPermissions.BacktestHistory.Default, L("Permission:BacktestHistory"));
            backtestHistoryPermission.AddChild(MarketWatchPermissions.BacktestHistory.Create, L("Permission:Create"));
            backtestHistoryPermission.AddChild(MarketWatchPermissions.BacktestHistory.Update, L("Permission:Update"));
            backtestHistoryPermission.AddChild(MarketWatchPermissions.BacktestHistory.Delete, L("Permission:Delete"));

            var fundTradeHistoryPermission = myGroup.AddPermission(MarketWatchPermissions.FundTradeHistory.Default, L("Permission:FundTradeHistory"));
            fundTradeHistoryPermission.AddChild(MarketWatchPermissions.FundTradeHistory.Create, L("Permission:Create"));
            fundTradeHistoryPermission.AddChild(MarketWatchPermissions.FundTradeHistory.Update, L("Permission:Update"));
            fundTradeHistoryPermission.AddChild(MarketWatchPermissions.FundTradeHistory.Delete, L("Permission:Delete"));

            var fundStrategyPermission = myGroup.AddPermission(MarketWatchPermissions.FundStrategy.Default, L("Permission:FundStrategy"));
            fundStrategyPermission.AddChild(MarketWatchPermissions.FundStrategy.Create, L("Permission:Create"));
            fundStrategyPermission.AddChild(MarketWatchPermissions.FundStrategy.Update, L("Permission:Update"));
            fundStrategyPermission.AddChild(MarketWatchPermissions.FundStrategy.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MarketWatchResource>(name);
        }
    }
}
