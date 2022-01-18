using Shouldly;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Xunit;
namespace ProductManagement.Products
{
    public class ProductAppService_Tests
        : ProductManagementApplicationTestBase
    {
        private readonly IProductAppService _productAppService;

        public ProductAppService_Tests()
        {
            _productAppService =
                GetRequiredService<IProductAppService>();
        }

        [Fact]
        public async Task Should_Get_Product_List()
        {
            //Act
            var output = await _productAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            //Assert
            output.TotalCount.ShouldBe(3);
            output.Items.ShouldContain(
                x => x.Name.Contains("Acme Monochrome Laser Printer")
            );
        }

    }
}
