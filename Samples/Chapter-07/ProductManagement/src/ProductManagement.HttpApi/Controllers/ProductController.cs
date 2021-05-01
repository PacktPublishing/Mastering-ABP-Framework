using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    /* Using permission based authorization with IAuthorizationService        
    public class ProductController : AbpController
    {
        private readonly IAuthorizationService _authorizationService;

        public ProductController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }
        
        public async Task CreateAsync(ProductCreationDto input)
        {
            if (await _authorizationService
                .IsGrantedAsync("ProductManagement.ProductCreation"))
            {
                //TODO: Create the product
            }
            else
            {
                //TODO: Handle unauthorized case
            }
        }
        
        public async Task CreateAlternativeAsync(ProductCreationDto input)
        {
            await _authorizationService
                .CheckAsync("ProductManagement.ProductCreation");
            //TODO: Create the product
        }
    }
    */
    /* Using permission based authorization with [Authorize] attribute */
    /*
    public class ProductController : Controller
    {
        public async Task<List<ProductDto>> GetListAsync()
        {
        }

        [Authorize("ProductManagement.ProductCreation")]
        public async Task CreateAsync(ProductCreationDto input)
        {
        }

        public async Task DeleteAsync(Guid id)
        {
        }
    }
    */

    /* Shows simple usage of [Authorize] and [AllowAnonymous] attributes on an MVC controller */

    /*
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
    public class ProductController : Controller
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

    public class ProductDto
    {
    }
    
    */
}