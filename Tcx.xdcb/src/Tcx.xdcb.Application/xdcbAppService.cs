using System;
using System.Collections.Generic;
using System.Text;
using Tcx.xdcb.Localization;
using Volo.Abp.Application.Services;

namespace Tcx.xdcb
{
    /* Inherit your application services from this class.
     */
    public abstract class xdcbAppService : ApplicationService
    {
        protected xdcbAppService()
        {
            LocalizationResource = typeof(xdcbResource);
        }
    }
}
