using Acme.Crm.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.Crm.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CrmPageModel : AbpPageModel
    {
        protected CrmPageModel()
        {
            LocalizationResourceType = typeof(CrmResource);
        }
    }
}