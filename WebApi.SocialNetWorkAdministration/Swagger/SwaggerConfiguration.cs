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
                c.Title = "Cars";
                c.DocumentName = SwagDocParts.Administration;
                c.ApiGroupNames = new[] { SwagDocParts.Administration};
                c.GenerateXmlObjects = true;
            });
            //.AddSwaggerDocument(c => 
            //{
            //    c.Title = "Weather";
            //    c.DocumentName = SwaggerDocParts.Weather;
            //    c.ApiGroupNames = new[] { SwaggerDocParts.Weather };
            //});
        }
    }
}
