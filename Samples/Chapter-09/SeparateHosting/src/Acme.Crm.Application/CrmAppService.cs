using System;
using System.Collections.Generic;
using System.Text;
using Acme.Crm.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Crm
{
    /* Inherit your application services from this class.
     */
    public abstract class CrmAppService : ApplicationService
    {
        protected CrmAppService()
        {
            LocalizationResource = typeof(CrmResource);
        }
    }
}
