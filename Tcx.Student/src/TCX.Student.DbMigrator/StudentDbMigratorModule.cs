using TCX.Student.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TCX.Student.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(StudentEntityFrameworkCoreDbMigrationsModule),
        typeof(StudentApplicationContractsModule)
        )]
    public class StudentDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
