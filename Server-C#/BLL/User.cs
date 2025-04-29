using I_BLL;
using I_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class User : I_BLL<DTO.User_Dto>
    {
        I_DAL<DTO.User_Dto> _Dal;
        public User(I_DAL<DTO.User_Dto> _dal)
        {
            _Dal = _dal;
        }
        public async Task<List<DTO.User_Dto>> GetAllAsync()
        {
            var q = await _Dal.GetAllAsync();
            return q;
        }

        public async Task<List<DTO.User_Dto>> AddAsync(DTO.User_Dto User)
        {
            var x = await _Dal.AddAsync(User);
            return x;
        }

        public async Task<List<DTO.User_Dto>> UpdateAsync(int id, DTO.User_Dto User)
        {
            var x = await _Dal.UpdateAsync(id, User);
            return x;
        }

        public async Task<List<DTO.User_Dto>> DeleteAsync(int id)
        {
            var x = await _Dal.DeleteAsync(id);
            return x;
        }
    }
}
