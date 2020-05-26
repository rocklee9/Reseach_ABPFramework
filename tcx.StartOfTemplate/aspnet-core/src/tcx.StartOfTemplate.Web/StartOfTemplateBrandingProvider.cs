using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace tcx.StartOfTemplate.Web
{
    [Dependency(ReplaceServices = true)]
    public class StartOfTemplateBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "StartOfTemplate";
    }
}
