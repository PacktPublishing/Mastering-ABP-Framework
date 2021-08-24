using MvcDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MvcDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MvcDemoEntityFrameworkCoreModule),
        typeof(MvcDemoApplicationContractsModule)
        )]
    public class MvcDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
