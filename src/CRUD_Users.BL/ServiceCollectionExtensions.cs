using CRUD_Users.BL.Services;
using CRUD_Users.BL.Services.Implementation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CRUD_Users.BL
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterBLServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserLogService, UserLogService>();
        }
    }
}
