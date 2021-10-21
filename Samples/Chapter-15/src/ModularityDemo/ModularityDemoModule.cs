using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ModularityDemo
{

    [DependsOn(
        typeof(AbpAutofacModule)
    )]
    public class ModularityDemoModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            var hostEnvironment = context.Services.GetSingletonInstance<IHostEnvironment>();

            context.Services.AddHostedService<ModularityDemoHostedService>();
        }
    }
}
