using I_BLL;
using DTO;
using System;
using System.ComponentModel;
using I_DAL;


namespace BLL
{
    public class CarModel : I_BLL<CarModel_Dto>
    {
        I_DAL<DTO.CarModel_Dto> _Dal;

        public CarModel(I_DAL<CarModel_Dto> _Dal)
        {
            this._Dal = _Dal;
        }

        public async Task<List<CarModel_Dto>> GetAllAsync()
        {
            var q = await _Dal.GetAllAsync();
            return q;
        }

        public async Task<List<DTO.CarModel_Dto>> AddAsync(DTO.CarModel_Dto CarModel)
        {
            if (CarModel.Img == null) CarModel.Img = "null.png";

            return await _Dal.AddAsync(CarModel);
        }

        public async Task<List<DTO.CarModel_Dto>> UpdateAsync(int id, DTO.CarModel_Dto CarModel)
        {
            return await _Dal.UpdateAsync(id, CarModel);
        }

        public async Task<List<DTO.CarModel_Dto>> DeleteAsync(int id)
        {
            return await _Dal.DeleteAsync(id);
        }

    }
}
