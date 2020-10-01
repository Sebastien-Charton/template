using System.Threading.Tasks;
using ApiBase.Datas.SettingModels;

namespace ApiBase.Repositories.ApiInfoRepo
{
    public class ApiInfoRepository : IApiInfoRepository
    {
        private ApiInfos _apiInfos { get; set; }
        public ApiInfoRepository(ApiInfos apiInfos)
        {
            _apiInfos = apiInfos;
        }

        public ApiInfos GetApiInfos()
        {
            return _apiInfos;
        }
    }
}