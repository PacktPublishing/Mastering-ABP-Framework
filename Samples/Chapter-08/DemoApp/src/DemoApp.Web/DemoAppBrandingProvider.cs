using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace DemoApp.Web
{
    [Dependency(ReplaceServices = true)]
    public class DemoAppBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "DemoApp";
    }
}
