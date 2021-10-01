using Volo.Abp.Settings;

namespace ApiDemo.Settings
{
    public class ApiDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ApiDemoSettings.MySetting1));
        }
    }
}
