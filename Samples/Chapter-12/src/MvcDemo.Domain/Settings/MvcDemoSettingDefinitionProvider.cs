using Volo.Abp.Settings;

namespace MvcDemo.Settings
{
    public class MvcDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MvcDemoSettings.MySetting1));
        }
    }
}
