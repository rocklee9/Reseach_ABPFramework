using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace tcx.StartOfTemplate.EntityFrameworkCore
{
    [DependsOn(
        typeof(StartOfTemplateEntityFrameworkCoreModule)
        )]
    public class StartOfTemplateEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<StartOfTemplateMigrationsDbContext>();
        }
    }
}
