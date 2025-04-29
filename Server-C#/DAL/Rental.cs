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
    public class Rental : I_DAL_Rental
    {
        public async Task<List<DTO.Rental_Dto>> GetAllAsync()
        {
            try
            {
                Models.RentalCarsContext db = new Models.RentalCarsContext();
                var list = Converters.RentalConverters.ToListRentalDto(await db.Rentals.ToListAsync());
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<DTO.Rental_Dto>> GetByIdAsync(int id)
        {
            try
            {
                Models.RentalCarsContext db = new Models.RentalCarsContext();
                var list = Converters.RentalConverters.ToListRentalDto(await db.Rentals.Where(r=>r.UserId==id && r.Returned==false).ToListAsync());
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public async Task<List<DTO.Rental_Dto>> AddAsync(DTO.Rental_Dto Rental)
        {
            try
            {
                Models.RentalCarsContext db = new Models.RentalCarsContext();
                db.Rentals.Add(DAL.Converters.RentalConverters.ToRentalModel(Rental));
                int x = await db.SaveChangesAsync();
                if (x > 0)
                    return DAL.Converters.RentalConverters.ToListRentalDto(db.Rentals.ToList<Models.Rental>());
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<List<DTO.Rental_Dto>> UpdateReturnedAsync(int id)
        {
            Models.RentalCarsContext db = new Models.RentalCarsContext();
            Models.Rental Rental1 = await db.Rentals.FirstOrDefaultAsync(t => t.Id == id);
            if (Rental1 == null)
                return null;
            Rental1.Returned  = true;
            int x = await db.SaveChangesAsync();
            if (x > 0)
                return DAL.Converters.RentalConverters.ToListRentalDto(db.Rentals.ToList<Models.Rental>());
            return null;
        }

        public async Task<List<DTO.Rental_Dto>> DeleteAsync(int id)
        {
            Models.RentalCarsContext db = new Models.RentalCarsContext();
            Models.Rental Rental1 = await db.Rentals.FirstOrDefaultAsync(t => t.Id == id);
            if (Rental1 == null)
                return null;
            db.Rentals.Remove(Rental1);
            int x = await db.SaveChangesAsync();
            if (x > 0)
                return DAL.Converters.RentalConverters.ToListRentalDto(db.Rentals.ToList<Models.Rental>());
            return null;
        }

        public async Task<List<DTO.Rental_Dto>> UpdateReturnAsync(int id)
        {
            Models.RentalCarsContext db = new Models.RentalCarsContext();
            Models.Rental Rental1 = await db.Rentals.FirstOrDefaultAsync(t => t.Id == id);
            if (Rental1 == null)
                return null;
            Rental1.Returned = true;
            int x = await db.SaveChangesAsync();
            if (x > 0)
                return DAL.Converters.RentalConverters.ToListRentalDto(db.Rentals.ToList<Models.Rental>());
            return null;
        }

        public Task<List<Rental_Dto>> UpdateAsync(int id, Rental_Dto item)
        {
            throw new NotImplementedException();
        }
    }
}
