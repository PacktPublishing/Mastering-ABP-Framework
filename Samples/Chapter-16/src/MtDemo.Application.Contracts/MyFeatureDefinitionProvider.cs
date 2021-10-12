using MtDemo.Localization;
using Volo.Abp.Features;
using Volo.Abp.Localization;
using Volo.Abp.Validation.StringValues;

namespace MtDemo
{
    public class MyFeatureDefinitionProvider : FeatureDefinitionProvider
    {
        public override void Define(IFeatureDefinitionContext context)
        {
            var myGroup = context.AddGroup("MyApp");
            
            myGroup.AddFeature(
                "MyApp.StockManagement",
                defaultValue: "false",
                displayName: L("StockManagement"),
                isVisibleToClients: true,
                valueType: new ToggleStringValueType());
            
            myGroup.AddFeature(
                "MyApp.MaxProductCount", 
                defaultValue: "100",
                displayName: L("MaxProductCount"),
                valueType: new FreeTextStringValueType(
                    new NumericValueValidator()));
        }

        private ILocalizableString L(string name)
        {
            return LocalizableString.Create<MtDemoResource>(name);
        }
    }
}