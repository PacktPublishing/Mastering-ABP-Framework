using Volo.Abp.Modularity;

namespace Acme.Crm
{
    [DependsOn(
        typeof(CrmApplicationModule),
        typeof(CrmDomainTestModule)
        )]
    public class CrmApplicationTestModule : AbpModule
    {

    }
}