using System;
using System.Linq;
using Shouldly;
using System.Threading.Tasks;
using ProductManagement.Categories;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Validation;
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

        [Fact]
        public async Task Should_Get_Category_Lookup()
        {
            var output = await _productAppService.GetCategoriesAsync();
            output.Items.Count.ShouldBeGreaterThanOrEqualTo(2);
            output.Items.ShouldContain(x => x.Name == "Monitors");
        }

        [Fact]
        public async Task Should_Create_A_Valid_Product()
        {
            var firstCategory = await WithUnitOfWorkAsync(
                async () => await GetRequiredService<IRepository<Category, Guid>>().FirstAsync()
            );
            
            var createProductDto = new CreateUpdateProductDto
            {
                Name = "Tarsus Gaming Laptop 17\"",
                Price = 2999,
                ReleaseDate = DateTime.Now,
                StockState = ProductStockState.InStock,
                CategoryId = firstCategory.Id,
                IsFreeCargo = true
            };
            
            await _productAppService.CreateAsync(createProductDto);

            await WithUnitOfWorkAsync(async () =>
            {
                var product = await GetRequiredService<IRepository<Product, Guid>>()
                    .FirstOrDefaultAsync(x => x.Name == createProductDto.Name);
                
                product.ShouldNotBeNull();
                product.Price.ShouldBe(createProductDto.Price);
                product.StockState.ShouldBe(createProductDto.StockState);
                product.CategoryId.ShouldBe(createProductDto.CategoryId);
                product.IsFreeCargo.ShouldBe(createProductDto.IsFreeCargo);
            });
        }

        [Fact]
        public async Task Should_Not_Allow_To_Create_Invalid_Product()
        {
            var firstCategory = await WithUnitOfWorkAsync(
                async () => await GetRequiredService<IRepository<Category, Guid>>().FirstAsync()
            );
            
            var createProductDto = new CreateUpdateProductDto
            {
                // Name is not provided, so we are expecting a validation error 
                Price = 2999,
                ReleaseDate = DateTime.Now,
                StockState = ProductStockState.InStock,
                CategoryId = firstCategory.Id,
                IsFreeCargo = true
            };

            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
                await _productAppService.CreateAsync(createProductDto)
            );
            
            exception.ValidationErrors.ShouldContain(x => x.MemberNames.Contains(nameof(CreateUpdateProductDto.Name)));
        }
    }
}
