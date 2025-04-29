using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_DAL
{
    public interface I_DAL_DriveType: I_DAL<DTO.DriveType_Dto>
    {
        Task<List<DTO.DriveType_Dto>> UpdatePriceAsync(int id, int price);
    }
}
