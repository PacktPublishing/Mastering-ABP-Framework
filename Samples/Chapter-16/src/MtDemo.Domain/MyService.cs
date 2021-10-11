using System;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.MultiTenancy;

namespace MtDemo
{
    public class MyService : ITransientDependency
    {
        private readonly ICurrentTenant _currentTenant;

        public MyService(ICurrentTenant currentTenant)
        {
            _currentTenant = currentTenant;
        }
        
        public async Task DoItAsync()
        {
            Guid? tenantId = _currentTenant.Id;
            string tenantName = _currentTenant.Name;
        }
    }
}
