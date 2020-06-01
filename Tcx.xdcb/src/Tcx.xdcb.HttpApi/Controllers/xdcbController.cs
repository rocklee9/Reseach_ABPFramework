using Tcx.xdcb.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Tcx.xdcb.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class xdcbController : AbpController
    {
        protected xdcbController()
        {
            LocalizationResource = typeof(xdcbResource);
        }
    }
}