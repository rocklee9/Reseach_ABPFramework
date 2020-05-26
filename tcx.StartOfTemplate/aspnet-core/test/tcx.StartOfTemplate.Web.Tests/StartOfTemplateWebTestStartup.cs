using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace tcx.StartOfTemplate
{
    public class StartOfTemplateWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<StartOfTemplateWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}