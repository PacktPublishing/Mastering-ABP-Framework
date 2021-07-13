using Acme.Crm.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.Crm.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CrmEntityFrameworkCoreModule),
        typeof(CrmApplicationContractsModule)
        )]
    public class CrmDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
