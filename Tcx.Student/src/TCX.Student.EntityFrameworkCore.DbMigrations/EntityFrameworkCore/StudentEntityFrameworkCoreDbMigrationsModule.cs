using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TCX.Student.EntityFrameworkCore
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
