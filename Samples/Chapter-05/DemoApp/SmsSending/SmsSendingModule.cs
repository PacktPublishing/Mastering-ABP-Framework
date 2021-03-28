using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace SmsSending
{
    public class SmsSendingModule : AbpModule 
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddTransient<SmsService>();
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