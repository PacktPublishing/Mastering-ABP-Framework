using ApiDemo.Products;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiDemo.Controllers
{
    /* ProductAppService is automatically converted to controller, so we don't
     * need to write such a wrapper controller class with the ABP Framework
     *
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public async Task<ProductDto> GetListAsync()
        {
            return await _productAppService.GetListAsync();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task UpdateAsync(Guid id, ProductUpdateDto input)
        {
            await _productAppService.UpdateAsync(id, input);
        }
    }
    */
}
