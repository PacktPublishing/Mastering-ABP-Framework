using ProductManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ProductManagement.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ProductManagementPageModel : AbpPageModel
    {
        protected ProductManagementPageModel()
        {
            LocalizationResourceType = typeof(ProductManagementResource);
        }
    }
}