using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_DAL
{
    public interface I_DAL_Car : I_DAL<DTO.Car_Dto>
    {
        Task<List<DTO.Car_Dto>> UpdateAvailableAsync(int id);
    }
}
