using Acme.Crm.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Crm.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CrmController : AbpController
    {
        protected CrmController()
        {
            LocalizationResource = typeof(CrmResource);
        }
    }
}