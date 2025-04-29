using DTO;
using I_DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarType : I_DAL<DTO.CarType_Dto>
    {
        public async Task<List<DTO.CarType_Dto>> GetAllAsync()
        {
            try
            {
                Models.RentalCarsContext db = new Models.RentalCarsContext();
                var list = Converters.CarTypeConverters.ToListCarTypeDto(await db.CarTypes.ToListAsync());
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<List<CarType_Dto>> AddAsync(CarType_Dto item)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarType_Dto>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarType_Dto>> UpdateAsync(int id, CarType_Dto item)
        {
            throw new NotImplementedException();
        }
    }
}
