using DemoApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DemoApp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DemoAppEntityFrameworkCoreDbMigrationsModule),
        typeof(DemoAppApplicationContractsModule)
        )]
    public class DemoAppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
