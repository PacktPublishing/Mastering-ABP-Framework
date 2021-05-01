using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;

namespace ProductManagement.Products
{
    public class ProductAppService
        : ApplicationService, IProductAppService
    {
        [Authorize("ProductManagement.ProductCreation")]
        public Task CreateAsync(ProductCreationDto input)
        {
            throw new NotImplementedException();
        }
    }
}