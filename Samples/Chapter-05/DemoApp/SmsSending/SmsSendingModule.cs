using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace SmsSending
{
    public class SmsSendingModule : AbpModule 
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            
            Configure<AzureSmsServiceOptions>(
                configuration.GetSection("AzureSmsService"));
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var myService = context
                .ServiceProvider
                .GetRequiredService<MyServiceNeedsToInit>();
            myService.Initialize();
        }
    }
}