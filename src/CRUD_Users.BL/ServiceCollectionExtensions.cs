using CRUD_Users.BL.Services;
using CRUD_Users.BL.Services.Implementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD_Users.BL
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterBLServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserLogService, UserLogService>();
        }
    }
}
