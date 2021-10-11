using MtDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MtDemo
{
    [DependsOn(
        typeof(MtDemoEntityFrameworkCoreTestModule)
        )]
    public class MtDemoDomainTestModule : AbpModule
    {

    }
}