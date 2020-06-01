using TCX.Student.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TCX.Student.Controllers
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