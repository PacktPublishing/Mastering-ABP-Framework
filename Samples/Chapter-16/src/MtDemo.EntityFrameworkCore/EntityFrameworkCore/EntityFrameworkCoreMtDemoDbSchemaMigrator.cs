using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MtDemo.Data;
using Volo.Abp.DependencyInjection;

namespace MtDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreMtDemoDbSchemaMigrator
        : IMtDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMtDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MtDemoDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MtDemoDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
