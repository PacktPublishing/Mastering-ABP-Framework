using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.Crm.Data
{
    /* This is used if database provider does't define
     * ICrmDbSchemaMigrator implementation.
     */
    public class NullCrmDbSchemaMigrator : ICrmDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}