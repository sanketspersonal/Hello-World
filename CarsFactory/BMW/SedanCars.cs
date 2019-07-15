using CarsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMW
{
    public class SedanCars : ICarBrand
    {
        public string GetCarBrand()
        {
            return "BMW";
        }

        public List<string> GetDetails()
        {
            return new List<string> { "BMW", "M5", "Sedan car" };
        }
    }
}
