using Volo.Abp.Modularity;

namespace MvcDemo
{
    [DependsOn(
        typeof(MvcDemoApplicationModule),
        typeof(MvcDemoDomainTestModule)
        )]
    public class MvcDemoApplicationTestModule : AbpModule
    {

    }
}