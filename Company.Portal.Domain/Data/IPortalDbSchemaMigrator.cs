using System.Threading.Tasks;

namespace Company.Portal.Data
{
    public interface IPortalDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
