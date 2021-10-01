using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ApiDemo.Data;
using Volo.Abp.DependencyInjection;

namespace ApiDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreApiDemoDbSchemaMigrator
        : IApiDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreApiDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ApiDemoDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ApiDemoDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
