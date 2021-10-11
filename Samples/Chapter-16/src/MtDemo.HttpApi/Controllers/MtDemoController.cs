using MtDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MtDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class MtDemoController : AbpControllerBase
    {
        protected MtDemoController()
        {
            LocalizationResource = typeof(MtDemoResource);
        }
    }
}