using DTO;
using I_BLL;
using I_DAL;
using System.ComponentModel;

namespace BLL
{
    public class CarType : I_BLL<DTO.CarType_Dto>        
    {

        I_DAL<DTO.CarType_Dto> _Dal;

        public CarType(I_DAL<CarType_Dto> _dal)
        {
            this._Dal = _dal;
        }
        public Task<List<CarType_Dto>> AddAsync(CarType_Dto item)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarType_Dto>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DTO.CarType_Dto>> GetAllAsync()
        {
            var q = await _Dal.GetAllAsync();
            return q;
        }

        public Task<List<CarType_Dto>> UpdateAsync(int id, CarType_Dto item)
        {
            throw new NotImplementedException();
        }
    }
}
