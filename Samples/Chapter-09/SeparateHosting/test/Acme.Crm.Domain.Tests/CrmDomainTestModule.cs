using Acme.Crm.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Crm
{
    [DependsOn(
        typeof(CrmEntityFrameworkCoreTestModule)
        )]
    public class CrmDomainTestModule : AbpModule
    {

    }
}