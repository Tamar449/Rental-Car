using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_BLL
{
    public interface I_BLL_Rental : I_BLL<DTO.Rental_Dto>
    {
        Task<List<DTO.Rental_Dto>> GetByIdAsync(int id);
        Task<List<DTO.Rental_Dto>> UpdateReturnedAsync(int id);

    }
}
