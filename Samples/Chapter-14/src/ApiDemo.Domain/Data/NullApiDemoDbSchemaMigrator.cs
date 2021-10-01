using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ApiDemo.Data
{
    /* This is used if database provider does't define
     * IApiDemoDbSchemaMigrator implementation.
     */
    public class NullApiDemoDbSchemaMigrator : IApiDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}