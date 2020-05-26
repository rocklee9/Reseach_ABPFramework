using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tcx.Student.Data;
using Volo.Abp.DependencyInjection;

namespace Tcx.Student.EntityFrameworkCore
{
    public class EntityFrameworkCoreStudentDbSchemaMigrator
        : IStudentDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreStudentDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the StudentMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<StudentMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}