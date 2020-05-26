using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace tcx.StartOfTemplate.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class StartOfTemplateMigrationsDbContextFactory : IDesignTimeDbContextFactory<StartOfTemplateMigrationsDbContext>
    {
        public StartOfTemplateMigrationsDbContext CreateDbContext(string[] args)
        {
            StartOfTemplateEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<StartOfTemplateMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new StartOfTemplateMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
