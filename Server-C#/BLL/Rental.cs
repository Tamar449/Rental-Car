using DTO;
using I_BLL;
using I_DAL;
using System.ComponentModel;

namespace BLL
{
    public class Rental : I_BLL_Rental
    {
        I_DAL_Rental _Dal;
        I_DAL_Car _DAL_Car;

        public Rental(I_DAL_Rental _dal, I_DAL_Car dAL_Car)
        {
            this._Dal = _dal;
            _DAL_Car = dAL_Car;
        }

        public async Task<List<DTO.Rental_Dto>> GetAllAsync()
        {
            var q = await _Dal.GetAllAsync();
            return q;
        }

        public async Task<List<DTO.Rental_Dto>> GetByIdAsync(int id)
        {
            var q = await _Dal.GetByIdAsync(id);
            return q;
        }

        public async Task<List<DTO.Rental_Dto>> AddAsync(DTO.Rental_Dto Rental)
        {
            int idCar = Rental.CarId;
            var cars = _DAL_Car.GetAllAsync();
            var car = cars.Result.Find(c => c.Id == idCar);
            if (!car.Available)
                throw new rentalException("available false!!!");
            return await _Dal.AddAsync(Rental);
        }

        public async Task<List<DTO.Rental_Dto>> UpdateReturnedAsync(int id)
        {
            return await _Dal.UpdateReturnedAsync(id);
        }

        public async Task<List<DTO.Rental_Dto>> DeleteAsync(int id)
        {
            return await _Dal.DeleteAsync(id);
        }

        public async Task<List<DTO.Rental_Dto>> UpdateReturnAsync(int id)
        {
            return await _Dal.UpdateReturnedAsync(id);
        }

        public Task<List<Rental_Dto>> UpdateAsync(int id, Rental_Dto item)
        {
            throw new NotImplementedException();
        }
    }
}
