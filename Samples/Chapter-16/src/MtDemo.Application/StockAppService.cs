using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Features;

namespace MtDemo
{
    [RequiresFeature("MyApp.StockManagement")]
    public class StockAppService : ApplicationService, IStockAppService
    {
        public async Task<int> GetCountAsync(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}