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

        Task CreateAsync(CreateProductDto input);

        Task<ListResultDto<CategoryLookupDto>> GetCategoriesAsync();
    }
}
