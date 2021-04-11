using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace FormsApp.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule)
        )]
    public class FormsDomainModule : AbpModule
    {
        
    }
}