using System;
using System.Collections.Generic;
using System.Text;
using Tcx.Student.Localization;
using Volo.Abp.Application.Services;

namespace Tcx.Student
{
    /* Inherit your application services from this class.
     */
    public abstract class StudentAppService : ApplicationService
    {
        protected StudentAppService()
        {
            LocalizationResource = typeof(StudentResource);
        }
    }
}
