using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Acme.Crm
{
    public class CrmWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<CrmWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}