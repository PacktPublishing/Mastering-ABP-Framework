using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Validation;

namespace ProductManagement.Products
{
    public class ProductAppService
        : ApplicationService, IProductAppService
    {
        public async Task CreateAsync(ProductCreationDto input)
        {
            if (await HasExistingProductAsync(input.Name))
            {
                throw new AbpValidationException(
                    new List<ValidationResult>
                    {
                        new ValidationResult(
                            "Product name is already in use!",
                            new[] {nameof(input.Name)}
                        )
                    }
                );
            }
        }

        public Task ExampleThrowsExceptionAsync()
        {
            throw new Exception("my error message...");
        }

        public Task ExampleThrowsUserFriendlyExceptionAsync()
        {
            throw new UserFriendlyException("This message is available to the user!");
        }

        [DisableValidation]
        public async Task CreateNotValidatingAsync(ProductCreationDto input)
        {
        }

        private async Task<bool> HasExistingProductAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}