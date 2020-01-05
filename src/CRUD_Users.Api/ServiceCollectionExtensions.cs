using CRUD_Users.Api.Services;
using CRUD_Users.Api.Services.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD_Users.Api
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterAPIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRemoteCallService, UserRemoteCallService>();
            services.AddScoped<IUserLogRemoteCallService, UserLogRemoteCallService>();
        }
    }
}
