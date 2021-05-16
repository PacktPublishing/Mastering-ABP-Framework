using DemoApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DemoApp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DemoAppPageModel : AbpPageModel
    {
        protected DemoAppPageModel()
        {
            LocalizationResourceType = typeof(DemoAppResource);
        }
    }
}