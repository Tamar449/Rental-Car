using I_BLL;
using I_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Return : I_BLL<DTO.Return_Dto>
    {
        I_DAL<DTO.Return_Dto> _Dal;
        public Return(I_DAL<DTO.Return_Dto> _dal)
        {
            _Dal = _dal; 
        }
       
        public async Task<List<DTO.Return_Dto>> GetAllAsync()
        {
            var q = await _Dal.GetAllAsync();
            return q;
        }

        public async Task<List<DTO.Return_Dto>> AddAsync(DTO.Return_Dto Return)
        {
            var x =  await _Dal.AddAsync(Return);
            return x;
        }

        public async Task<List<DTO.Return_Dto>> UpdateAsync(int id, DTO.Return_Dto Return)
        {
            var x = await _Dal.UpdateAsync(id, Return);
            return x;
        }

        public async Task<List<DTO.Return_Dto>> DeleteAsync(int id)
        {
            var x = await _Dal.DeleteAsync(id);
            return x;
        }
    }
}
