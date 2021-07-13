using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.Crm.Web
{
    [Dependency(ReplaceServices = true)]
    public class CrmBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Crm";
    }
}
