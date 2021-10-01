using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ApiDemo
{
    [Dependency(ReplaceServices = true)]
    public class ApiDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ApiDemo";
    }
}
