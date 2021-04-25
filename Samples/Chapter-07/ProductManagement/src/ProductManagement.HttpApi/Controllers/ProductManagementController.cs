using ProductManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ProductManagementController : AbpController
    {
        protected ProductManagementController()
        {
            LocalizationResource = typeof(ProductManagementResource);
        }
    }
}