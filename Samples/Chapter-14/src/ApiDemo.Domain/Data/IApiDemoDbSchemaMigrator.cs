using System.Threading.Tasks;

namespace ApiDemo.Data
{
    public interface IApiDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
