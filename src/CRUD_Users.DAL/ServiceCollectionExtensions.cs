using CRUD_Users.DAL.DBContext;
using CRUD_Users.DAL.DBContext.Implementation;
using CRUD_Users.DAL.Repositories;
using CRUD_Users.DAL.Repositories.Implementation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CRUD_Users.DAL
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterDbContext(this IServiceCollection services, Func<string> GetConnectionString)
        {
            services.AddDbContext<AppDBContext>(options =>
            {
                options.UseSqlServer(GetConnectionString());
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddScoped<IAppDBContext, AppDBContext>();
        }

        public static void RegisterDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserLogRepository, UserLogRepository>();
        }
    }
}
