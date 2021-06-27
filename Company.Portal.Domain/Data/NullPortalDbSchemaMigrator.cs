using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Company.Portal.Data
{
    /* This is used if database provider does't define
     * IPortalDbSchemaMigrator implementation.
     */
    public class NullPortalDbSchemaMigrator : IPortalDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}