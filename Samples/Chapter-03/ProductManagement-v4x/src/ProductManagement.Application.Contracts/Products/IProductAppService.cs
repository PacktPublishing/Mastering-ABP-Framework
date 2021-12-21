using System;
using System.Threading.Tasks;
using ProductManagement.Categories;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ProductManagement.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<PagedResultDto<ProductDto>>
            GetListAsync(PagedAndSortedResultRequestDto input);

        Task CreateAsync(CreateUpdateProductDto input);

        Task<ListResultDto<CategoryLookupDto>> GetCategoriesAsync();
        
        Task<ProductDto> GetAsync(Guid id);
        
        Task UpdateAsync(Guid id, CreateUpdateProductDto input);

        Task DeleteAsync(Guid id);
    }
}
