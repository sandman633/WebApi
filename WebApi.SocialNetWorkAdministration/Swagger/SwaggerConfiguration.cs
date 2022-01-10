using Microsoft.Extensions.DependencyInjection;
using NSwag;
using NSwag.Generation.Processors.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.SocialNetWorkAdministration.Swagger;

namespace AspNetWebApiHomework.Swagger
{
    /// <summary>
    /// Описывает конфигурацию сваггера
    /// </summary>
    public static class SwaggerConfiguration
    {
        /// <summary>
        /// Настраиваем документ свагера
        /// </summary>
        /// <param name="services">Коллекция сервисов для DI</param>
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerDocument(config => {
                config.DocumentProcessors.Add(new SecurityDefinitionAppender("JWT Token",
                    new OpenApiSecurityScheme
                    {
                        Type = OpenApiSecuritySchemeType.ApiKey,
                        Name = "Authorization",
                        Description = "Copy 'Bearer ' + valid JWT token into field",
                        In = OpenApiSecurityApiKeyLocation.Header
                    }));
            });
            services.AddSwaggerDocument(c =>
            {
                c.Title = "News";
                c.DocumentName = SwagDocParts.News;
                c.ApiGroupNames = new[] { SwagDocParts.News};
                c.GenerateXmlObjects = true;
            });
            services.AddSwaggerDocument(c =>
            {
                c.Title = "User";
                c.DocumentName = SwagDocParts.User;
                c.ApiGroupNames = new[] { SwagDocParts.User};
                c.GenerateXmlObjects = true;
            });
        }
    }
}
