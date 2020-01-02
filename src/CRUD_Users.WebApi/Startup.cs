using CRUD_Users.Api;
using CRUD_Users.BL;
using CRUD_Users.DAL;
using Goober.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD_Users.WebApi
{
    public class Startup : GooberStartup
    {
        public Startup(IHostingEnvironment env, IConfiguration config) : base(env, config)
        {
        }

        protected override void ConfigureServiceCollections(IServiceCollection services)
        {
            services.RegisterDbContext(() => Configuration.GetConnectionString("APPDB"));
            services.RegisterAPIServices();
            services.RegisterBLServices();
            services.RegisterDALServices();
            services.AddCors();
        }

        protected override void ConfigurePipelineAfterExceptionsHandling(IApplicationBuilder app)
        {
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        }

        protected override void ConfigurePipelineAfterMvc(IApplicationBuilder app)
        {
        }
    }
}
