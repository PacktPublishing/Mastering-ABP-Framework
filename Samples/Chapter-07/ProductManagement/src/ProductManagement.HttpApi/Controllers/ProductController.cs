using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    public class ProductController : Controller
    {
        public async Task<List<ProductDto>> GetListAsync()
        {
        }

        [Authorize]
        public async Task CreateAsync(ProductCreationDto input)
        {
        }

        [Authorize]
        public async Task DeleteAsync(Guid id)
        {
        }
    }

    [Authorize]
    public class AlternativeProductController : Controller
    {
        [AllowAnonymous]
        public async Task<List<ProductDto>> GetListAsync()
        {
        }

        public async Task CreateAsync(ProductCreationDto input)
        {
        }

        public async Task DeleteAsync(Guid id)
        {
        }
    }

    public class ProductCreationDto
    {
    }

    public class ProductDto
    {
    }
}