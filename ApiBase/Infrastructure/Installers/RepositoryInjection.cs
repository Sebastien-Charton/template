using ApiBase.Repositories.ApiInfoRepo;
using Microsoft.Extensions.DependencyInjection;

namespace ApiBase.Infrastructure.Installers
{
    public static class RepositoryInjection
    {
        public static void AddRepositoriesInjection(this IServiceCollection services)
        {
            services.AddScoped<IApiInfoRepository, ApiInfoRepository>();
        }
    }
}