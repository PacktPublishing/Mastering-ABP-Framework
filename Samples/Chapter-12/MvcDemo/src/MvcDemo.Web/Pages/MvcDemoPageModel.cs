using MvcDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MvcDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MvcDemoPageModel : AbpPageModel
    {
        protected MvcDemoPageModel()
        {
            LocalizationResourceType = typeof(MvcDemoResource);
        }
    }
}