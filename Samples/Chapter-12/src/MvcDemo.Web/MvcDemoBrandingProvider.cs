using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MvcDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class MvcDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MvcDemo";
    }
}
