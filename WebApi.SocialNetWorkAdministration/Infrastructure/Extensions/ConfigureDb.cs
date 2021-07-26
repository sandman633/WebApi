using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DAL.Domain;

namespace WebApi.SocialNetWorkAdministration.Infrastructure.Extensions
{
    public static class ConfigureDb
    {
        public static void ConfigurationDb(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<WebApiContext>(options => options.UseNpgsql(configuration.GetConnectionString(nameof(WebApiContext)), builder => builder.MigrationsAssembly(typeof(WebApiContext).Assembly.FullName)));
            service.AddTransient<SeedDb>();
        }
    }
}
