using MtDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MtDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MtDemoPageModel : AbpPageModel
    {
        protected MtDemoPageModel()
        {
            LocalizationResourceType = typeof(MtDemoResource);
        }
    }
}