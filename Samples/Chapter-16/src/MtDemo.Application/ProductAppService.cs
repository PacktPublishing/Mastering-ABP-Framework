using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Features;
using Volo.Abp.MultiTenancy;

namespace MtDemo
{
    public class ProductAppService : ApplicationService
    {
        private readonly IRepository<Product, Guid> _productRepository;

        public ProductAppService(IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<long> GetStockCount2Async()
        {
            if (await FeatureChecker.IsEnabledAsync("MyApp.StockManagement"))
            {
                return await _productRepository.GetCountAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task<long> GetStockCount3Async()
        {
            await FeatureChecker.CheckEnabledAsync("MyApp.StockManagement");
            return await _productRepository.GetCountAsync();
        }

        [RequiresFeature("MyApp.StockManagement")]
        public async Task<long> GetStockCountAsync()
        {
            return await _productRepository.GetCountAsync();
        }

        [RequiresFeature("MyApp.StockManagement")]
        public async Task<long> GetTotalProductCountAsync()
        {
            using (DataFilter.Disable<IMultiTenant>())
            {
                return await _productRepository.GetCountAsync();
            }
        }

        public async Task CreateAsync(string name)
        {
            var product = new Product(
                GuidGenerator.Create(),
                name,
                CurrentTenant.Id
            );

            await _productRepository.InsertAsync(product);
        }
        
        public async Task Create2Async(string name)
        {
            var currentProductCount = await _productRepository.GetCountAsync();
            var maxProductCount = await FeatureChecker.GetAsync<int>("MyApp.MaxProductCount");
            if (currentProductCount >= maxProductCount)
            {
                // TODO: Throw a business exception
            }
            
            var product = new Product(
                GuidGenerator.Create(),
                name,
                CurrentTenant.Id
            );

            await _productRepository.InsertAsync(product);
        }
    }
}