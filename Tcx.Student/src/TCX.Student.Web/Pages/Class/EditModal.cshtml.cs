using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TCX.Student.Schema;

namespace TCX.Student.Web.Pages.Class
{
    public class EditModalModel : StudentPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateUpdateClassDto Class { get; set; }

        private readonly IClassAppService _classAppService;

        public EditModalModel(IClassAppService classAppService)
        {
            _classAppService = classAppService;
        }

        public async Task OnGetAsync()
        {
            var classDto = await _classAppService.GetAsync(Id);
            Class = ObjectMapper.Map<ClassDto, CreateUpdateClassDto>(classDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _classAppService.UpdateAsync(Id, Class);
            return NoContent();
        }
    }
}