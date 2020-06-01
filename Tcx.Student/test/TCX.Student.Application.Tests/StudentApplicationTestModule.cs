using Volo.Abp.Modularity;

namespace TCX.Student
{
    [DependsOn(
        typeof(StudentApplicationModule),
        typeof(StudentDomainTestModule)
        )]
    public class StudentApplicationTestModule : AbpModule
    {

    }
}