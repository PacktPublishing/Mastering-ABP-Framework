using Volo.Abp.Modularity;

namespace MtDemo
{
    [DependsOn(
        typeof(MtDemoApplicationModule),
        typeof(MtDemoDomainTestModule)
        )]
    public class MtDemoApplicationTestModule : AbpModule
    {

    }
}