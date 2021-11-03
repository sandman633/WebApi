using Microsoft.Extensions.DependencyInjection;
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
            services.AddSwaggerDocument(c =>
            {
                c.Title = "Administration";
                c.DocumentName = SwagDocParts.News;
                c.ApiGroupNames = new[] { SwagDocParts.News};
                c.GenerateXmlObjects = true;
            });
        }
    }
}
