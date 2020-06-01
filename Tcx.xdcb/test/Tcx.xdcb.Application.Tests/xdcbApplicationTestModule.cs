using Volo.Abp.Modularity;

namespace Tcx.xdcb
{
    [DependsOn(
        typeof(xdcbApplicationModule),
        typeof(xdcbDomainTestModule)
        )]
    public class xdcbApplicationTestModule : AbpModule
    {

    }
}