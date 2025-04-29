using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_WebApi
{
    public interface I_WebApi_DriveType
    {
        Task<List<DTO.DriveType_Dto>> UpdatePriceAsync(int id, int price);

    }
}
