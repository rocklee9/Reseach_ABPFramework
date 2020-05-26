using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Tcx.Student
{
    public class StudentWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<StudentWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}