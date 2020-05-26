using Volo.Abp.Modularity;

namespace Tcx.Student
{
    [DependsOn(
        typeof(StudentApplicationModule),
        typeof(StudentDomainTestModule)
        )]
    public class StudentApplicationTestModule : AbpModule
    {

    }
}