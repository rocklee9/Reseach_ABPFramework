using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace tcx.StartOfTemplate.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(StartOfTemplateHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class StartOfTemplateConsoleApiClientModule : AbpModule
    {
        
    }
}
