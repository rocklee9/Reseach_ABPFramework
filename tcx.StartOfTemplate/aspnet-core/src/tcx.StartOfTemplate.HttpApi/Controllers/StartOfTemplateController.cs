using tcx.StartOfTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace tcx.StartOfTemplate.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class StartOfTemplateController : AbpController
    {
        protected StartOfTemplateController()
        {
            LocalizationResource = typeof(StartOfTemplateResource);
        }
    }
}