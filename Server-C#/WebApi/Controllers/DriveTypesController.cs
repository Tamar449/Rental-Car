using I_BLL;
using I_WebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriveTypesController : ControllerBase , I_WebApi_DriveType
    {
        I_BLL_DriveType _Bll;
        public DriveTypesController(I_BLL_DriveType _bll)
        {
            _Bll = _bll;
        }

        [HttpGet]
        public async Task<List<DTO.DriveType_Dto>> GetAllAsync()
        {
            var q = await _Bll.GetAllAsync();
            return q;
        }

        [HttpPost]
        public async Task<List<DTO.DriveType_Dto>> AddAsync(DTO.DriveType_Dto c)
        {
            var q = await _Bll.AddAsync(c);
            return q;
        }

        [HttpPut]
        public async Task<List<DTO.DriveType_Dto>> UpdatePriceAsync(int id, int price)
        {
            return await _Bll.UpdatePriceAsync(id, price);
        }

        [HttpDelete]
        public async Task<List<DTO.DriveType_Dto>> DeleteAsync(int id)
        {
            var q = await _Bll.DeleteAsync(id);
            return q;
        }

    }
}
