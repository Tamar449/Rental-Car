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
    public class DriveType : I_DAL_DriveType
    {
        public async Task<List<DTO.DriveType_Dto>> GetAllAsync()
        {
            try
            {
                Models.RentalCarsContext db = new Models.RentalCarsContext();
                var list = Converters.DriveTypeConverters.ToListDriveTypeDto(await db.DriveTypes.ToListAsync());
                return list;
            }
            catch(Exception e) 
            { 
                throw e;
            }
        }

        public async Task<List<DTO.DriveType_Dto>> AddAsync(DTO.DriveType_Dto driveType)
        {
            try
            {
                Models.RentalCarsContext db = new Models.RentalCarsContext();
                db.DriveTypes.Add(DAL.Converters.DriveTypeConverters.ToDriveTypeModel(driveType));
                int x = await db.SaveChangesAsync();
                if (x > 0)
                    return DAL.Converters.DriveTypeConverters.ToListDriveTypeDto(db.DriveTypes.ToList<Models.DriveType>());
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<DTO.DriveType_Dto>> UpdatePriceAsync(int id, int price)
        {
            Models.RentalCarsContext db = new Models.RentalCarsContext();
            Models.DriveType driveType1 = await db.DriveTypes.FirstOrDefaultAsync(t => t.Id == id);
            if (driveType1 == null)
                return null;
            driveType1.PricePerLiter = price;
            int x = await db.SaveChangesAsync();
            if (x > 0)
                return DAL.Converters.DriveTypeConverters.ToListDriveTypeDto(db.DriveTypes.ToList<Models.DriveType>());
            return null;
        }

        public async Task<List<DTO.DriveType_Dto>> DeleteAsync(int id)
        {
            Models.RentalCarsContext db = new Models.RentalCarsContext();
            Models.DriveType driveType1 = await db.DriveTypes.FirstOrDefaultAsync(t => t.Id == id);
            if (driveType1 == null)
                return null;
            db.DriveTypes.Remove(driveType1);
            int x = await db.SaveChangesAsync();
            if (x > 0)
                return DAL.Converters.DriveTypeConverters.ToListDriveTypeDto(db.DriveTypes.ToList<Models.DriveType>());
            return null;
        }

        public Task<List<DriveType_Dto>> UpdateAsync(int id, DriveType_Dto item)
        {
            throw new NotImplementedException();
        }
    }
}
