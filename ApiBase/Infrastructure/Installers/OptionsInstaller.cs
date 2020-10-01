using ApiBase.Datas.SettingModels;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBase.Infrastructure.Installers
{
    public static class OptionsInstaller
    {
        public static void AddOptionsInjection(this IServiceCollection services, IConfiguration configuration)
        {
            var apiInfos = new ApiInfos();
            configuration.Bind("ApiInfos", apiInfos);
            services.AddSingleton(apiInfos);
        }
    }
}