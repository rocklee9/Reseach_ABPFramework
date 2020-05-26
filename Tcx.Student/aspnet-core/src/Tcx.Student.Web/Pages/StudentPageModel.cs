using Tcx.Student.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Tcx.Student.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class StudentPageModel : AbpPageModel
    {
        protected StudentPageModel()
        {
            LocalizationResourceType = typeof(StudentResource);
        }
    }
}