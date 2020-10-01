using ApiBase.Datas.SettingModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBase.Infrastructure.Installers
{
    public static class CorsInstaller
    {
        public static void AddCorsInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder
                    .AllowAnyMethod()
                    .WithOrigins(configuration.GetSection("CorsSettings").Get<CorsSettings>().Origins)
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .WithExposedHeaders(configuration.GetSection("CorsSettings").Get<CorsSettings>().AllowedHeaders)
                );
            });
        }

        public static void AddCorsApp(this IApplicationBuilder app)
        {
            app.UseCors("CorsPolicy");
        }
    }
}