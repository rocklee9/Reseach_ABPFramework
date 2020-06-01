using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TCX.Student.Web.Pages.Class
{
    public class CreateModalModel : StudentPageModel
    {
        [BindProperty]
        public CreateUpdateClassDto Class { get; set; }

        private readonly IClassAppService _iclassAppService;

        public CreateModalModel(IClassAppService iclassAppService)
        {
            _iclassAppService = iclassAppService;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _iclassAppService.CreateAsync(Class);
            return NoContent();
        }
    }
}