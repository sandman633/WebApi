using Microsoft.Extensions.DependencyInjection;
using Repositories.Implementations;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.SocialNetWorkAdministration.Infrastructure.Extensions
{

    public static class RepositoryRegistrator
    {
        public static void Registerepository(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICommentsRepository, CommentsRepository>();
            services.AddTransient<INewsRepository, NewsRepository>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();
        }
    }
}
