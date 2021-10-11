using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MtDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class MtDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "MtDemo";
    }
}
