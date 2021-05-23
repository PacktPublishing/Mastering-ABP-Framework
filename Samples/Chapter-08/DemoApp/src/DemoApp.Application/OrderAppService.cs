using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Auditing;

namespace DemoApp
{
    [DisableAuditing]
    public class OrderAppService : ApplicationService, IOrderAppService
    {
        public async Task CreateAsync(CreateOrderDto input)
        {
        }

        [Audited]
        public async Task DeleteAsync(Guid id)
        {
        }
    }
}