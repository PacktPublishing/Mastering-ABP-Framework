using MvcDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MvcDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MvcDemoController : AbpController
    {
        protected MvcDemoController()
        {
            LocalizationResource = typeof(MvcDemoResource);
        }
    }
}