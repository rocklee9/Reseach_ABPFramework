using TCX.Student.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TCX.Student
{
    [DependsOn(
        typeof(StudentEntityFrameworkCoreTestModule)
        )]
    public class StudentDomainTestModule : AbpModule
    {

    }
}