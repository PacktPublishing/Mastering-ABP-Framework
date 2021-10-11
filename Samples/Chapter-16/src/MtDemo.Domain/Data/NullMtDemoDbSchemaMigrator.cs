using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MtDemo.Data
{
    /* This is used if database provider does't define
     * IMtDemoDbSchemaMigrator implementation.
     */
    public class NullMtDemoDbSchemaMigrator : IMtDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}