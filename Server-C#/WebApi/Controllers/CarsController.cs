using I_BLL;
using I_WebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase , I_WebApi_Car
    {
        I_BLL_Car _Bll;
        public CarsController(I_BLL_Car _bll)
        {
            _Bll = _bll;
        }

        [HttpGet]
        public async Task<List<DTO.Car_Dto>> GetAllAsync()
        {
            var q = await _Bll.GetAllAsync();
            return q;
        }

        [HttpPost]
        public async Task<List<DTO.Car_Dto>> AddAsync(DTO.Car_Dto c)
        {
            var q = await _Bll.AddAsync(c);
            return q;
        }

        [HttpPut]
        public async Task<List<DTO.Car_Dto>> UpdateAsync(int id, DTO.Car_Dto c)
        {
            var q = await _Bll.UpdateAsync(id, c);
            return q;
        }


        [HttpPut]
        [Route("available")]

        public async Task<List<DTO.Car_Dto>> UpdateAvailableAsync(int id)
        {
            var q = await _Bll.UpdateAvailableAsync(id);
            return q;
        }

        [HttpDelete]
        public async Task<List<DTO.Car_Dto>> DeleteAsync(int id)
        {
            var q = await _Bll.DeleteAsync(id);
            return q;
        }


    }
}
