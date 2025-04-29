using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Converters
{
    public class RentalConverters
    {
        public static DTO.Rental_Dto ToRentalDto(Models.Rental Rental)
        {
            DTO.Rental_Dto Rental1 = new DTO.Rental_Dto();
            Rental1.Id = Rental.Id;
            Rental1.CarId = Rental.CarId;
            Rental1.UserId = Rental.UserId;
            Rental1.DateAndTime = Rental.DateAndTime;
            Rental1.Returned = Rental.Returned;
            return Rental1;

        }

        public static List<DTO.Rental_Dto> ToListRentalDto(List<Models.Rental> listRentals)
        {
            List<DTO.Rental_Dto> lnew = new List<DTO.Rental_Dto>();
            foreach (var item in listRentals)
            {
                lnew.Add(ToRentalDto(item));
            }
            return lnew;
        }


        public static Models.Rental ToRentalModel(DTO.Rental_Dto Rental)
        {
            Models.Rental Rental1 = new Models.Rental();
            Rental1.Id = Rental.Id;
            Rental1.CarId = Rental.CarId;
            Rental1.UserId = Rental.UserId;
            Rental1.DateAndTime = Rental.DateAndTime;
            Rental1.Returned = Rental.Returned;
            return Rental1;

        }
    }
}
