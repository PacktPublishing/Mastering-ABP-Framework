using System.Threading.Tasks;

namespace Acme.Crm.Data
{
    public interface ICrmDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
