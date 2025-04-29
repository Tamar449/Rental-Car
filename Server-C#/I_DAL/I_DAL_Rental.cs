using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_DAL
{
    public interface I_DAL_Rental : I_DAL<DTO.Rental_Dto>
    {
        Task<List<DTO.Rental_Dto>> GetByIdAsync(int id);
        Task<List<DTO.Rental_Dto>> UpdateReturnedAsync(int id);
    }
}
