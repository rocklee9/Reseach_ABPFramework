using Tcx.xdcb.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Tcx.xdcb.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class xdcbPageModel : AbpPageModel
    {
        protected xdcbPageModel()
        {
            LocalizationResourceType = typeof(xdcbResource);
        }
    }
}