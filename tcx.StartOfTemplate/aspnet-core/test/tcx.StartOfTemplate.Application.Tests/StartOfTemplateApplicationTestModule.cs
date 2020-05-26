using Volo.Abp.Modularity;

namespace tcx.StartOfTemplate
{
    [DependsOn(
        typeof(StartOfTemplateApplicationModule),
        typeof(StartOfTemplateDomainTestModule)
        )]
    public class StartOfTemplateApplicationTestModule : AbpModule
    {

    }
}