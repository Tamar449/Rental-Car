using I_BLL;
using I_WebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReturnsController : ControllerBase , I_WebApi<DTO.Return_Dto>
    {
        I_BLL<DTO.Return_Dto> _Bll;
        public ReturnsController(I_BLL<DTO.Return_Dto> _bll)
        {
            _Bll = _bll;
        }

        [HttpGet]
        public async Task<List<DTO.Return_Dto>> GetAllAsync()
        {
            var q = await _Bll.GetAllAsync();
            return q;
        }

        [HttpPost]
        public async Task<List<DTO.Return_Dto>> AddAsync(DTO.Return_Dto c)
        {
            var q = await _Bll.AddAsync(c);
            return q;
        }

        [HttpPut]
        public async Task<List<DTO.Return_Dto>> UpdateAsync(int id, DTO.Return_Dto c)
        {
            var q = await _Bll.UpdateAsync(id, c);
            return q;
        }

        [HttpDelete]
        public async Task<List<DTO.Return_Dto>> DeleteAsync(int id)
        {
            var q = await _Bll.DeleteAsync(id);
            return q;
        }
    }
}
