using I_BLL;
using I_WebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase , I_WebApi<DTO.User_Dto>
    {
        I_BLL<DTO.User_Dto> _Bll;
        public UsersController(I_BLL<DTO.User_Dto> _bll)
        {
            _Bll = _bll;
        }

        [HttpGet]
        public async Task<List<DTO.User_Dto>> GetAllAsync()
        {
            var q = await _Bll.GetAllAsync();
            return q;
        }

        [HttpPost]
        public async Task<List<DTO.User_Dto>> AddAsync(DTO.User_Dto u)
        {
            var q = await _Bll.AddAsync(u);
            return q;
        }

        [HttpPut]
        public async Task<List<DTO.User_Dto>> UpdateAsync(int id, DTO.User_Dto u)
        {
            var q = await _Bll.UpdateAsync(id, u);
            return q;
        }

        [HttpDelete]
        public async Task<List<DTO.User_Dto>> DeleteAsync(int id)
        {
            var q = await _Bll.DeleteAsync(id);
            return q;
        }
    }
}
