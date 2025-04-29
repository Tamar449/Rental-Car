using System.ComponentModel;
using DTO;
using I_BLL;
using I_DAL;

namespace BLL
{
    public class Car : I_BLL_Car
    {
        I_DAL_Car _Dal;

        public Car(I_DAL_Car _dal)
        {
            this._Dal = _dal;
        }

        public async Task<List<Car_Dto>> GetAllAsync()
        {
            var q = await _Dal.GetAllAsync();
            return q;
        }

        public async Task<List<DTO.Car_Dto>> AddAsync(DTO.Car_Dto car)
        {
            var x = await _Dal.AddAsync(car);
            return x;
        }

        public async Task<List<DTO.Car_Dto>> UpdateAsync(int id, DTO.Car_Dto car)
        {
            var x = await _Dal.UpdateAsync(id, car);
            return x;
        }

        public async Task<List<DTO.Car_Dto>> UpdateAvailableAsync(int id)
        {
            return await _Dal.UpdateAvailableAsync(id);
        }


        public async Task<List<DTO.Car_Dto>> DeleteAsync(int id)
        {
            var x = await _Dal.DeleteAsync(id);
            return x;
        }

    }
}
