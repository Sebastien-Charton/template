using System.Threading.Tasks;
using ApiBase.Datas.SettingModels;

namespace ApiBase.Repositories.ApiInfoRepo
{
    public interface IApiInfoRepository
    {
        ApiInfos GetApiInfos();
    }
}