using MvcDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MvcDemo
{
    [DependsOn(
        typeof(MvcDemoEntityFrameworkCoreTestModule)
        )]
    public class MvcDemoDomainTestModule : AbpModule
    {

    }
}