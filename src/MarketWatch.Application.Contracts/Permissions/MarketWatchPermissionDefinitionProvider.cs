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
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<MarketWatchResource>(name);
        }
    }
}
