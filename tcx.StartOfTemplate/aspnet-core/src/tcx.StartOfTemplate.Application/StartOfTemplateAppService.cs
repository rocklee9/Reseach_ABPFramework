using System;
using System.Collections.Generic;
using System.Text;
using tcx.StartOfTemplate.Localization;
using Volo.Abp.Application.Services;

namespace tcx.StartOfTemplate
{
    /* Inherit your application services from this class.
     */
    public abstract class StartOfTemplateAppService : ApplicationService
    {
        protected StartOfTemplateAppService()
        {
            LocalizationResource = typeof(StartOfTemplateResource);
        }
    }
}
