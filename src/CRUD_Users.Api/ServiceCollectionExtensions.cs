using CRUD_Users.Api.Services;
using CRUD_Users.Api.Services.Implementation;
using Goober.Core.Services;
using Goober.Core.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD_Users.Api
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterAPIServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRemoteCallService, UserRemoteCallService>();
            services.AddScoped<IUserLogRemoteCallService, UserLogRemoteCallService>();
            services.AddScoped<ICacheProvider, CacheProvider>();
        }
    }
}
