using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.MultiTenancy;

namespace MtDemo
{
    public class MyAppService : ApplicationService
    {
        public async Task DoItAsync(Guid tenantId)
        {
            // Before the using block
            using (CurrentTenant.Change(tenantId))
            {
                // Inside the using block
                // CurrentTenant.Id equals to tenantId 
            }
            // After the using block
        }
    }
}