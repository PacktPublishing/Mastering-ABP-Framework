using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
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
    }
}