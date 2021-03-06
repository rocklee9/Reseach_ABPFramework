﻿using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Tcx.Student.Web
{
    [Dependency(ReplaceServices = true)]
    public class StudentBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Student";
    }
}
