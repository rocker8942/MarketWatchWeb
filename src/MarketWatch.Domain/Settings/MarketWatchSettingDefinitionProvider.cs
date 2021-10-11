using Volo.Abp.Settings;

namespace MarketWatch.Settings
{
    public class MarketWatchSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MarketWatchSettings.MySetting1));
        }
    }
}
