using BLL;
using I_BLL;
using I_WebApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase , I_WebApi_Rental
    {
        I_BLL_Rental _Bll;
        public RentalsController(I_BLL_Rental _bll)
        {
            _Bll = _bll;
        }

        [HttpGet]
        public async Task<List<DTO.Rental_Dto>> GetAllAsync()
        {
            var q = await _Bll.GetAllAsync();
            return q;
        }

        [HttpGet("{id}")]
        public async Task<List<DTO.Rental_Dto>> GetByIdAsync(int id)
        {
            var q = await _Bll.GetByIdAsync(id);
            return q;
        }

        [HttpPost]
        public async Task<List<DTO.Rental_Dto>> AddAsync(DTO.Rental_Dto c)
        {
            try
            {
                var q = await _Bll.AddAsync(c);
                return q;
            }
            catch (rentalException ex)
            {
                Response.StatusCode = 462;
                return null;
            }
        }

        [HttpPut]
        public async Task<List<DTO.Rental_Dto>> UpdateReturnedAsync(int id)
        {
            return await _Bll.UpdateReturnedAsync(id);
        }

        [HttpDelete]
        public async Task<List<DTO.Rental_Dto>> DeleteAsync(int id)
        {
            return await _Bll.DeleteAsync(id);
        }

    }
}
