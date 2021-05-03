using FluentValidation;

namespace ProductManagement.Products
{
    public class ProductCreationDtoValidator
        : AbstractValidator<ProductCreationDto>
    {
        public ProductCreationDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
            RuleFor(x => x.Price).ExclusiveBetween(0, 1000);
            //...
        }
    }
}