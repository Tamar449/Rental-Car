using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Converters
{
    public class CarModelConverters
    {
        public static DTO.CarModel_Dto ToCarModelDto(Models.CarModel CarModel)
        {
            DTO.CarModel_Dto CarModel1 = new DTO.CarModel_Dto();
            CarModel1.Company = CarModel.Company;
            CarModel1.Model = CarModel.Model;
            CarModel1.CarTypeId = CarModel.CarTypeId;
            CarModel1.Img = CarModel.Img;
            CarModel1.Id = CarModel.Id;
            return CarModel1;

        }

        public static List<DTO.CarModel_Dto> ToListCarModelDto(List<Models.CarModel> listCarModels)
        {
            List<DTO.CarModel_Dto> lnew = new List<DTO.CarModel_Dto>();
            foreach (var item in listCarModels)
            {
                lnew.Add(ToCarModelDto(item));
            }
            return lnew;
        }


        public static Models.CarModel ToCarModelModel(DTO.CarModel_Dto CarModel)
        {
            Models.CarModel CarModel1 = new Models.CarModel();
            CarModel1.Company = CarModel.Company;
            CarModel1.Model = CarModel.Model;
            CarModel1.CarTypeId = CarModel.CarTypeId;
            CarModel1.Img = CarModel.Img;
            CarModel1.Id = CarModel.Id;
            return CarModel1;

        }
    }
}
