using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Converters
{
    public class DriveTypeConverters
    {
        public static DTO.DriveType_Dto ToDriveTypeDto(Models.DriveType driveType)
        {
            DTO.DriveType_Dto driveType1 = new DTO.DriveType_Dto();
            driveType1.PricePerLiter = driveType.PricePerLiter;
            driveType1.Description = driveType.Description;
            driveType1.Id = driveType.Id;
            return driveType1;

        }

        public static List<DTO.DriveType_Dto> ToListDriveTypeDto(List<Models.DriveType> listCars)
        {
            List<DTO.DriveType_Dto> lnew = new List<DTO.DriveType_Dto>();
            foreach (var item in listCars)
            {
                lnew.Add(ToDriveTypeDto(item));
            }
            return lnew;
        }


        public static Models.DriveType ToDriveTypeModel(DTO.DriveType_Dto driveType)
        {
            Models.DriveType driveType1 = new Models.DriveType();
            driveType1.PricePerLiter = driveType.PricePerLiter;
            driveType1.Description = driveType.Description;
            return driveType1;

        }
    }
}
