using Volo.Abp.DependencyInjection;
using Volo.Abp.Validation;

namespace ProductManagement.Products
{
    public class SomeServiceWithValidation
        : IValidationEnabled, ITransientDependency
    {
        // All inputs of methods of this class is validated automatically
    }
}