using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;
using Volo.Abp.FeatureManagement;

namespace MtDemo
{
    public class MyCustomerService : DomainService
    {
        private readonly IFeatureManager _featureManager;

        public MyCustomerService(IFeatureManager featureManager)
        {
            _featureManager = featureManager;
        }
        
        public async Task EnableStockManagementAsync(Guid tenantId)
        {
            await _featureManager.SetForTenantAsync(
                tenantId,
                "MyApp.StockManagement",
                "true"
            );
        }
    }
}