using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ProductManagement.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task CreateAsync(ProductCreationDto input);

        Task ExampleThrowsExceptionAsync();
    }
}