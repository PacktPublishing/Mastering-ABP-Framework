using MtDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MtDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MtDemoEntityFrameworkCoreModule),
        typeof(MtDemoApplicationContractsModule)
        )]
    public class MtDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
