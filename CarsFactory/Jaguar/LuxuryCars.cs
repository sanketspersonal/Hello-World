using CarsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jaguar
{
    public class LuxuryCars : ICarBrand
    {
        public string GetCarBrand()
        {
            return "Jaguar";
        }

        public List<string> GetDetails()
        {
            return new List<string> { "Jaguar", "XJ", "Luxury Sedan car" };
        }
    }
}
