using ApiDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ApiDemo
{
    [DependsOn(
        typeof(ApiDemoEntityFrameworkCoreTestModule)
        )]
    public class ApiDemoDomainTestModule : AbpModule
    {

    }
}