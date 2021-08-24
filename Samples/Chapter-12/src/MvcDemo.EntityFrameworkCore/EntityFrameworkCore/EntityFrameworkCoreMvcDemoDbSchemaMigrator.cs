using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcDemo.Data;
using Volo.Abp.DependencyInjection;

namespace MvcDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreMvcDemoDbSchemaMigrator
        : IMvcDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMvcDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MvcDemoDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MvcDemoDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
