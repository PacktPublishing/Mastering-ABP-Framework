using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MvcDemo.Data
{
    /* This is used if database provider does't define
     * IMvcDemoDbSchemaMigrator implementation.
     */
    public class NullMvcDemoDbSchemaMigrator : IMvcDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}