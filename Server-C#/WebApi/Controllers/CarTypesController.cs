using DTO;
using I_BLL;
using I_WebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTypesController : ControllerBase, I_WebApi<DTO.CarType_Dto>
    {
        I_BLL<DTO.CarType_Dto> _Bll;
        public CarTypesController(I_BLL<DTO.CarType_Dto> _bll)
        {
            _Bll = _bll;
        }


        [HttpGet]
        public async Task<List<DTO.CarType_Dto>> GetAllAsync()
        {
            var q = await _Bll.GetAllAsync();
            return q;
        }

        [HttpPost]
        public Task<List<CarType_Dto>> AddAsync(CarType_Dto item)
        {
            return _Bll.AddAsync(item);
        }

        [HttpPut]
        public Task<List<CarType_Dto>> UpdateAsync(int id, CarType_Dto item)
        {
            return _Bll.UpdateAsync(id, item);
        }

        [HttpDelete]
        public Task<List<CarType_Dto>> DeleteAsync(int id)
        {
            return _Bll.DeleteAsync(id);
        }

    }
}
