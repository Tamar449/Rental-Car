using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_WebApi
{
    public interface I_WebApi_Car : I_WebApi<DTO.Car_Dto>
    {
        Task<List<DTO.Car_Dto>> UpdateAvailableAsync(int id);

    }
}
