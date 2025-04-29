using I_BLL;
using I_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserType : I_BLL<DTO.UserType_Dto>
    {
        I_DAL<DTO.UserType_Dto> _Dal;
        public UserType(I_DAL<DTO.UserType_Dto> _dal)
        {
            _Dal = _dal;
        }

        public async Task<List<DTO.UserType_Dto>> GetAllAsync()
        {
            var q = await _Dal.GetAllAsync();
            return q;
        }

        public async Task<List<DTO.UserType_Dto>> AddAsync(DTO.UserType_Dto UserType)
        {
            var x = await _Dal.AddAsync(UserType);
            return x;
        }

        public async Task<List<DTO.UserType_Dto>> UpdateAsync(int id, DTO.UserType_Dto UserType)
        {
            var x = await _Dal.UpdateAsync(id, UserType);
            return x;
        }

        public async Task<List<DTO.UserType_Dto>> DeleteAsync(int id)
        {
            var x = await _Dal.DeleteAsync(id);
            return x;
        }
    }
}
