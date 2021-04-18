using System.Data;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace FormsApp
{
    [DependsOn(
        typeof(AbpDddDomainModule)
    )]
    public class FormsDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpUnitOfWorkDefaultOptions>(options =>
            {
                options.TransactionBehavior = UnitOfWorkTransactionBehavior.Enabled;
                options.Timeout = 300000; // 5 minutes
                options.IsolationLevel = IsolationLevel.Serializable;
            });
        }
    }
}