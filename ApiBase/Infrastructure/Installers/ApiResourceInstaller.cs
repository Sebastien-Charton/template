
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBase.Infrastructure.Installers
{
    public static class ApiResourceInstaller
    {
        public static void ApiResourcesInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCorsInjection(configuration);

            services.AddOptionsInjection(configuration);

            services.AddRepositoriesInjection();

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerService();
        }

        public static void ApiResourcesInjectionApp(this IApplicationBuilder app)
        {
            app.AddCorsApp();

            app.AddSwaggerApp();
        }
    }
}