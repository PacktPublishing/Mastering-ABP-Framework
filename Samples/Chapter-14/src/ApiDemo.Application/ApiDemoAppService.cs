using System;
using System.Collections.Generic;
using System.Text;
using ApiDemo.Localization;
using Volo.Abp.Application.Services;

namespace ApiDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class ApiDemoAppService : ApplicationService
    {
        protected ApiDemoAppService()
        {
            LocalizationResource = typeof(ApiDemoResource);
        }
    }
}
