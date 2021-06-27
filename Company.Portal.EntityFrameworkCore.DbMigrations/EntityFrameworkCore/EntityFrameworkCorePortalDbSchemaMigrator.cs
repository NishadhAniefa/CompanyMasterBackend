using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Company.Portal.Data;
using Volo.Abp.DependencyInjection;

namespace Company.Portal.EntityFrameworkCore
{
    public class EntityFrameworkCorePortalDbSchemaMigrator
        : IPortalDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePortalDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the PortalMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<PortalMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}