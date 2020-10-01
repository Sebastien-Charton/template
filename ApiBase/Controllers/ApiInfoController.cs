using System.Threading.Tasks;
using ApiBase.Datas.SettingModels;
using ApiBase.Repositories.ApiInfoRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace ApiBase.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ApiInfoController : ControllerBase
    {
        private IApiInfoRepository _apiInfoRepository;

        public ApiInfoController(IApiInfoRepository apiInfoRepository)
        {
            _apiInfoRepository = apiInfoRepository;
        }

        [ProducesResponseType(typeof(ApiInfos), Status200OK)]
        [HttpGet("[action]")]
        public IActionResult GetApiInfos()
        {
            var infos = _apiInfoRepository.GetApiInfos();
            return Ok(infos);
        }
    }
}