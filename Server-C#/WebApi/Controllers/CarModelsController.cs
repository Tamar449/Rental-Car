using I_BLL;
using I_DAL;
using I_WebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelsController : ControllerBase , I_WebApi<DTO.CarModel_Dto>
    {
        I_BLL<DTO.CarModel_Dto> _Bll;
        public CarModelsController(I_BLL<DTO.CarModel_Dto> _bll)
        {
            _Bll = _bll;
        }

        [HttpGet]
        public async Task<List<DTO.CarModel_Dto>> GetAllAsync()
        {
            var q = await _Bll.GetAllAsync();
            return q;
        }

        [HttpPost]
        public async Task<List<DTO.CarModel_Dto>> AddAsync(DTO.CarModel_Dto c)
        {
            Console.WriteLine(c);
            Console.WriteLine(c.Company);
            var q = await _Bll.AddAsync(c);
            return q;
        }

        [HttpPut]
        public async Task<List<DTO.CarModel_Dto>> UpdateAsync(int id, DTO.CarModel_Dto c)
        {
            return await _Bll.UpdateAsync(id, c);
        }

        [HttpDelete]
        public async Task<List<DTO.CarModel_Dto>> DeleteAsync(int id)
        {
            return await _Bll.DeleteAsync(id);
        }

    }
}
