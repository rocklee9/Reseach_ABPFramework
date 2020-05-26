using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using tcx.StartOfTemplate.Data;
using Volo.Abp.DependencyInjection;

namespace tcx.StartOfTemplate.EntityFrameworkCore
{
    public class EntityFrameworkCoreStartOfTemplateDbSchemaMigrator
        : IStartOfTemplateDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreStartOfTemplateDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the StartOfTemplateMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<StartOfTemplateMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}