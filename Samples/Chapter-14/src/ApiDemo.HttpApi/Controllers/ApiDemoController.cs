using ApiDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ApiDemoController : AbpController
    {
        protected ApiDemoController()
        {
            LocalizationResource = typeof(ApiDemoResource);
        }
    }
}