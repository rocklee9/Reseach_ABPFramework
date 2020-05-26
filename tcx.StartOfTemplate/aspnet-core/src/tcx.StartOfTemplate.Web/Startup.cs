using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace tcx.StartOfTemplate.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<StartOfTemplateWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
