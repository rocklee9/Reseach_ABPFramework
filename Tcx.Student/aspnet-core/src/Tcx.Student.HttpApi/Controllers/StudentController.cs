using Tcx.Student.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Tcx.Student.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class StudentController : AbpController
    {
        protected StudentController()
        {
            LocalizationResource = typeof(StudentResource);
        }
    }
}