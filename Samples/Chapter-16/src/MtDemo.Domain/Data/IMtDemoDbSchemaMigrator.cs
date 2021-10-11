using System.Threading.Tasks;

namespace MtDemo.Data
{
    public interface IMtDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
