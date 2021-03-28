using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SmsSending;
using Volo.Abp.Auditing;
using Volo.Abp.Modularity;

namespace DemoApp.Web
{
    [DependsOn(typeof(SmsSendingModule))]
    public class MyStartupModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();

            Configure<AzureSmsServiceOptions>(options =>
            {
                options.Sender = configuration["AzureSmsService:Sender"];
                options.ConnStr = configuration["AzureSmsService:ConnStr"];
            });
            
Configure<AbpAuditingOptions>(options =>
{
    options.IgnoredTypes.Add(typeof(ProductDto));
});

Configure<MvcOptions>(options =>
{
    options.RespectBrowserAcceptHeader = true;
});
        }
    }
}