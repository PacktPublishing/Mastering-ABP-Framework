using System;
using System.Collections.Generic;
using System.Text;
using MtDemo.Localization;
using Volo.Abp.Application.Services;

namespace MtDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class MtDemoAppService : ApplicationService
    {
        protected MtDemoAppService()
        {
            LocalizationResource = typeof(MtDemoResource);
        }
    }
}
