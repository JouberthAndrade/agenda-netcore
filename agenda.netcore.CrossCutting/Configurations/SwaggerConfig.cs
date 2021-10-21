using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace agenda.netcore.CrossCutting.Configurations
{
	public static class SwaggerConfig
    {
    
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "agenda-netcore",
                    Description = "API - agenda.api",
                    Version = "v1"
                });

                var apiPath = Path.Combine(AppContext.BaseDirectory, "agenda.netcore.api.xml");

                var applicationPath = Path.Combine(AppContext.BaseDirectory, "agenda.netcore.Application.xml");

                c.IncludeXmlComments(apiPath);

                c.IncludeXmlComments(applicationPath);
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/agenda-netcore/swagger/v1/swagger.json", "API agenda-netcore");
            });

            return app;
        }
    }
}
