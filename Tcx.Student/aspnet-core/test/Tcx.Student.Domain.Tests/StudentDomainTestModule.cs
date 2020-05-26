using Tcx.Student.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Tcx.Student
{
    [DependsOn(
        typeof(StudentEntityFrameworkCoreTestModule)
        )]
    public class StudentDomainTestModule : AbpModule
    {

    }
}