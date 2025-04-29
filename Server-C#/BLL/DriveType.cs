using DTO;
using I_BLL;
using I_DAL;
using System.ComponentModel;

namespace BLL
{
    public class DriveType : I_BLL_DriveType
    {

        I_DAL_DriveType _Dal;

        public DriveType(I_DAL_DriveType _dal)
        {
            this._Dal = _dal;
        }
        public async Task<List<DTO.DriveType_Dto>> GetAllAsync()
        {
            var q = await _Dal.GetAllAsync();
            return q;
        }

        public async Task<List<DTO.DriveType_Dto>> AddAsync(DTO.DriveType_Dto driveType)
        {
            return await _Dal.AddAsync(driveType);
        }

        public async Task<List<DTO.DriveType_Dto>> UpdatePriceAsync(int id, int price)
        {
            return await _Dal.UpdatePriceAsync(id, price);
        }

        public async Task<List<DTO.DriveType_Dto>> DeleteAsync(int id)
        {
            return await _Dal.DeleteAsync(id);
        }

        public Task<List<DriveType_Dto>> UpdateAsync(int id, DriveType_Dto item)
        {
            throw new NotImplementedException();
        }
    }
}
