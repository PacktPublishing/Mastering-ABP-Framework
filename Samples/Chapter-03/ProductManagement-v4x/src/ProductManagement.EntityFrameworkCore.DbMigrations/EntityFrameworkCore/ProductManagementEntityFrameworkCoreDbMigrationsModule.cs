using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ProductManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(ProductManagementEntityFrameworkCoreModule)
        )]
    public class ProductManagementEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ProductManagementMigrationsDbContext>();
        }
    }
}
