using Tcx.xdcb.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Tcx.xdcb
{
    [DependsOn(
        typeof(xdcbEntityFrameworkCoreTestModule)
        )]
    public class xdcbDomainTestModule : AbpModule
    {

    }
}