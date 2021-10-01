using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ApiDemo.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<ProductDto> GetListAsync();

        Task UpdateAsync(Guid id, ProductUpdateDto input);
    }
}