using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TCX.Student.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TCX.Student.Web.Pages
{
    public abstract class StudentPageModelBaseModel : AbpPageModel
    {
        protected StudentPageModelBaseModel()
        {
            LocalizationResourceType = typeof(StudentResource);
        }
    }
}