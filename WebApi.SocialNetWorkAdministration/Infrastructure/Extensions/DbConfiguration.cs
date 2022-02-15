using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Model;

namespace WebApi.SocialNetWorkAdministration.Infrastructure.Extensions
{
    public static class DbConfiguration
    {
        public static void DbConfigure(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddDbContext<WebApiContext>(options => 
            options.UseNpgsql(configuration.GetConnectionString(nameof(WebApiContext)), 
            builder => builder.MigrationsAssembly(typeof(WebApiContext).Assembly.FullName)));
            
        }
    }
}
