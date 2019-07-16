using CarsInterfaces;
using CommonSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarsRepository
{
    public class CarRepository : ICarsRepository
    {
        public List<string> GetCarDetails(string CarBrand)
        {
            List<string> lst = new List<string>();
            ICarBrand obj;
            switch (CarBrand)
            {
                case "Audi":
                    obj = CarsObjectBinding.GetTypeObject(CarBrand);
                    lst = obj.GetDetails();
                    break;
                case "BMW":
                    obj = CarsObjectBinding.GetTypeObject(CarBrand);
                    lst = obj.GetDetails();
                    break;
                case "Jaguar":
                    obj = CarsObjectBinding.GetTypeObject(CarBrand);
                    lst = obj.GetDetails();
                    break;
                default:
                    break;
            }
            return lst;
        }
    }
}
