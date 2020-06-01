﻿using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tcx.xdcb.Data;
using Volo.Abp.DependencyInjection;

namespace Tcx.xdcb.EntityFrameworkCore
{
    public class EntityFrameworkCorexdcbDbSchemaMigrator
        : IxdcbDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorexdcbDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the xdcbMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<xdcbMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}