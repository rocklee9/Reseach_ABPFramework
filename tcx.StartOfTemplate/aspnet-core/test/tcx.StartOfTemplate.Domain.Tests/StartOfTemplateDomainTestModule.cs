using tcx.StartOfTemplate.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace tcx.StartOfTemplate
{
    [DependsOn(
        typeof(StartOfTemplateEntityFrameworkCoreTestModule)
        )]
    public class StartOfTemplateDomainTestModule : AbpModule
    {

    }
}