using ApiDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ApiDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ApiDemoEntityFrameworkCoreModule),
        typeof(ApiDemoApplicationContractsModule)
        )]
    public class ApiDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
