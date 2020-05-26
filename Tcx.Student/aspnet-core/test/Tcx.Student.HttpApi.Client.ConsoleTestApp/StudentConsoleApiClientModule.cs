using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Tcx.Student.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(StudentHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class StudentConsoleApiClientModule : AbpModule
    {
        
    }
}
