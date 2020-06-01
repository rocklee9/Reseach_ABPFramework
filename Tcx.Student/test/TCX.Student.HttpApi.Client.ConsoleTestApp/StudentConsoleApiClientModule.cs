using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace TCX.Student.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(StudentHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class StudentConsoleApiClientModule : AbpModule
    {
        
    }
}
