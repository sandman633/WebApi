using BL.AdminLogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.SocialNetWorkAdministration.Infrastructure.Extensions
{
    public static class ServicesRegistrator
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IAdminService, AdminService>();
        }
    }
}
