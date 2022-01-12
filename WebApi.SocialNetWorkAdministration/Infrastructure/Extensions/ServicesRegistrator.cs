using BL.Services;
using BL.Services.Implementations;
using BL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Implementations;
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
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICommentsService, CommentsService>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IUserRoleService, UserRoleService>();
        }
    }
}
