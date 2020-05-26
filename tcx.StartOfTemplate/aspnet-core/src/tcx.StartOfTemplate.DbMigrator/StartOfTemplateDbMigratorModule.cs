using tcx.StartOfTemplate.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace tcx.StartOfTemplate.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(StartOfTemplateEntityFrameworkCoreDbMigrationsModule),
        typeof(StartOfTemplateApplicationContractsModule)
        )]
    public class StartOfTemplateDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
