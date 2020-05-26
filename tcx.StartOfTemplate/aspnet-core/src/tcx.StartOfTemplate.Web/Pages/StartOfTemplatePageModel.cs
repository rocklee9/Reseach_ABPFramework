using tcx.StartOfTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace tcx.StartOfTemplate.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class StartOfTemplatePageModel : AbpPageModel
    {
        protected StartOfTemplatePageModel()
        {
            LocalizationResourceType = typeof(StartOfTemplateResource);
        }
    }
}