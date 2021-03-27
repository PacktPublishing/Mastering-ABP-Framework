using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace DemoApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(DemoAppEntityFrameworkCoreModule)
        )]
    public class DemoAppEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DemoAppMigrationsDbContext>();
        }
    }
}
