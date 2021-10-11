using Volo.Abp.Settings;

namespace MtDemo.Settings
{
    public class MtDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(MtDemoSettings.MySetting1));
        }
    }
}
