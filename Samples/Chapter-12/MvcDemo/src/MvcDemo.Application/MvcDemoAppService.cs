using System;
using System.Collections.Generic;
using System.Text;
using MvcDemo.Localization;
using Volo.Abp.Application.Services;

namespace MvcDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class MvcDemoAppService : ApplicationService
    {
        protected MvcDemoAppService()
        {
            LocalizationResource = typeof(MvcDemoResource);
        }
    }
}
