using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.Crm.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.Crm.EntityFrameworkCore
{
    public class EntityFrameworkCoreCrmDbSchemaMigrator
        : ICrmDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCrmDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CrmDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CrmDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
