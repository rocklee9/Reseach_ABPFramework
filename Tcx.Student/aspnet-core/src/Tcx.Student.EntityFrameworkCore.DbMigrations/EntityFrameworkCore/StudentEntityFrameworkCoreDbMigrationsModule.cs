using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Tcx.Student.EntityFrameworkCore
{
    [DependsOn(
        typeof(StudentEntityFrameworkCoreModule)
        )]
    public class StudentEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<StudentMigrationsDbContext>();
        }
    }
}
