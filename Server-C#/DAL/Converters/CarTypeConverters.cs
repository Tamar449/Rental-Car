using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Converters
{
    public class CarTypeConverters
    {
        public static DTO.CarType_Dto ToCarTypeDto(Models.CarType CarType)
        {
            DTO.CarType_Dto CarType1 = new DTO.CarType_Dto();
            CarType1.Description = CarType.Description;
            CarType1.Id = CarType.Id;
            return CarType1;

        }

        public static List<DTO.CarType_Dto> ToListCarTypeDto(List<Models.CarType> listCarTypes)
        {
            List<DTO.CarType_Dto> lnew = new List<DTO.CarType_Dto>();
            foreach (var item in listCarTypes)
            {
                lnew.Add(ToCarTypeDto(item));
            }
            return lnew;
        }


        public static Models.CarType ToCarTypeModel(DTO.CarType_Dto CarType)
        {
            Models.CarType CarType1 = new Models.CarType();
            CarType1.Description = CarType.Description;
            CarType1.Id = CarType.Id;
            return CarType1;

        }
    }
}
