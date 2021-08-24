using System.Threading.Tasks;

namespace MvcDemo.Data
{
    public interface IMvcDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
