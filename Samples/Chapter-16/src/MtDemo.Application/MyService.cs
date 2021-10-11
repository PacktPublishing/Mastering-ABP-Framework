using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace MtDemo
{
    public class MyAppService : ApplicationService
    {
        public async Task DoItAsync()
        {
            Guid? tenantId = CurrentTenant.Id;
        }
    }
}
