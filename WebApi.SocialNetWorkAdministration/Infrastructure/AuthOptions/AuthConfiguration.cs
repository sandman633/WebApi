using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;

namespace WebApi.SocialNetWorkAdministration.Infrastructure.AuthOptions
{
    public static class AuthConfiguration
    {
        /// <summary>
        /// Настройка jwt аутентификации
        /// </summary>
        /// <param name="services">Коллекция сервисов</param>
        /// <param name="jwtTokenConfig">Конфиг токена из настроек приложения</param>
        public static void AddJwtAuthentification(this IServiceCollection services, JwtTokenConfig jwtTokenConfig)
        {
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                // the authentication requires HTTPS for the metadata address or authority
                x.RequireHttpsMetadata = true;
                // saves the JWT access token in the current HttpContext,
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwtTokenConfig.Issuer,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = jwtTokenConfig.GetSymmetricSecurityKey(),
                    ValidAudience = jwtTokenConfig.Audience,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromMinutes(1)
                };
            });
        }

    }
}
