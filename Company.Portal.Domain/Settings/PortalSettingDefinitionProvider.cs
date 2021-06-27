using Volo.Abp.Settings;

namespace Company.Portal.Settings
{
    public class PortalSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PortalSettings.MySetting1));
        }
    }
}
