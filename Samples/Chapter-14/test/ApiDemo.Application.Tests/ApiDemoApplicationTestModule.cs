using Volo.Abp.Modularity;

namespace ApiDemo
{
    [DependsOn(
        typeof(ApiDemoApplicationModule),
        typeof(ApiDemoDomainTestModule)
        )]
    public class ApiDemoApplicationTestModule : AbpModule
    {

    }
}