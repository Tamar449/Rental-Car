using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_WebApi
{
    public interface I_WebApi_Rental
    {
        Task<List<DTO.Rental_Dto>> GetByIdAsync(int id);
        Task<List<DTO.Rental_Dto>> UpdateReturnedAsync(int id);

    }
}
