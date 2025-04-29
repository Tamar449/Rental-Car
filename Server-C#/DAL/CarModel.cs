using I_DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarModel : I_DAL<DTO.CarModel_Dto>
    {
        public async Task<List<DTO.CarModel_Dto>> GetAllAsync()
        {
            try
            {
                Models.RentalCarsContext db = new Models.RentalCarsContext();
                var list = Converters.CarModelConverters.ToListCarModelDto(await db.CarModels.ToListAsync());
                return list;
            }
            catch(Exception e) 
            { 
                throw e;
            }
        }

        public async Task<List<DTO.CarModel_Dto>> AddAsync(DTO.CarModel_Dto CarModel)
        {
            try
            {
                Models.RentalCarsContext db = new Models.RentalCarsContext();
                db.CarModels.Add(DAL.Converters.CarModelConverters.ToCarModelModel(CarModel));
                int x = await db.SaveChangesAsync();
                if (x > 0)
                    return DAL.Converters.CarModelConverters.ToListCarModelDto(db.CarModels.ToList<Models.CarModel>());
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<DTO.CarModel_Dto>> UpdateAsync(int id, DTO.CarModel_Dto CarModel)
        {
            Models.RentalCarsContext db = new Models.RentalCarsContext();
            Models.CarModel CarModel1 = await db.CarModels.FirstOrDefaultAsync(t => t.Id == id);
            if (CarModel1 == null)
                return null;
            CarModel1.Company = CarModel.Company;
            CarModel1.Model = CarModel.Model;
            CarModel1.CarTypeId = CarModel.CarTypeId;
            CarModel1.Img = CarModel.Img;
            int x = await db.SaveChangesAsync();
            if (x > 0)
                return DAL.Converters.CarModelConverters.ToListCarModelDto(db.CarModels.ToList<Models.CarModel>());
            return null;
        }

        public async Task<List<DTO.CarModel_Dto>> DeleteAsync(int id)
        {
            Models.RentalCarsContext db = new Models.RentalCarsContext();
            Models.CarModel CarModel1 = await db.CarModels.FirstOrDefaultAsync(t => t.Id == id);
            if (CarModel1 == null)
                return null;
            db.CarModels.Remove(CarModel1);
            int x = await db.SaveChangesAsync();
            if (x > 0)
                return DAL.Converters.CarModelConverters.ToListCarModelDto(db.CarModels.ToList<Models.CarModel>());
            return null;
        }
    }
}
