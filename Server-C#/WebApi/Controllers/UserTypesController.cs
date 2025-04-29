using I_BLL;
using I_WebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypeController : ControllerBase, I_WebApi<DTO.UserType_Dto>
    {
        I_BLL<DTO.UserType_Dto> _Bll;
        public UserTypeController(I_BLL<DTO.UserType_Dto> _bll)
        {
            _Bll = _bll;
        }

        [HttpGet]
        public async Task<List<DTO.UserType_Dto>> GetAllAsync()
        {
            var q = await _Bll.GetAllAsync();
            return q;
        }

        [HttpPost]
        public async Task<List<DTO.UserType_Dto>> AddAsync(DTO.UserType_Dto c)
        {
            var q = await _Bll.AddAsync(c);
            return q;
        }

        [HttpPut]
        public async Task<List<DTO.UserType_Dto>> UpdateAsync(int id, DTO.UserType_Dto c)
        {
            var q = await _Bll.UpdateAsync(id, c);
            return q;
        }

        [HttpDelete]
        public async Task<List<DTO.UserType_Dto>> DeleteAsync(int id)
        {
            var q = await _Bll.DeleteAsync(id);
            return q;
        }
    }
}
