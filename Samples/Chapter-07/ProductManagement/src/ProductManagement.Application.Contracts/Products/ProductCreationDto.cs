using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using ProductManagement.Localization;

namespace ProductManagement.Products
{
    public class ProductCreationDto : IValidatableObject
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Range(0, 999.99)]
        public decimal Price { get; set; }
        
        [Url]
        public string PictureUrl { get; set; }
        
        public bool IsDraft { get; set; }
        
        public IEnumerable<ValidationResult> Validate(
            ValidationContext context)
        {
            if (IsDraft == false &&
                string.IsNullOrEmpty(PictureUrl))
            {
                var localizer = context
                    .GetRequiredService<IStringLocalizer<ProductManagementResource>>();
                
                yield return new ValidationResult(
                    localizer["PictureIsMissingErrorMessage"],
                    new []{ nameof(PictureUrl) }
                );
            }
        }
    }
}