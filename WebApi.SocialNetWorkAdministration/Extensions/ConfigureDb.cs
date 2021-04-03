using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApi.SocialNetWorkAdministration.Models;

namespace WebApi.SocialNetWorkAdministration.Extensions
{
    public static class ConfigureDb
    {
        public static void ConfigurationDb(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<AdminContext>(options => options.UseNpgsql(configuration.GetConnectionString(nameof(AdminContext)), builder => builder.MigrationsAssembly(typeof(AdminContext).Assembly.FullName)));
            service.AddTransient<SeedDb>();
        }
    }
}
