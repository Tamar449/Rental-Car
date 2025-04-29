using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_BLL
{
    public interface I_BLL_DriveType : I_BLL<DTO.DriveType_Dto>
    {
        Task<List<DTO.DriveType_Dto>> UpdatePriceAsync(int id, int price);

    }
}
