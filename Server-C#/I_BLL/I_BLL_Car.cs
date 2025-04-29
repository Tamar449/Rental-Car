using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_BLL
{
    public interface I_BLL_Car : I_BLL<DTO.Car_Dto>
    {
        Task<List<DTO.Car_Dto>> UpdateAvailableAsync(int id);
    }
}
