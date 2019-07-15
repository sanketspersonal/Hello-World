using CarsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audi
{
    public class SportsCars : ICarBrand
    {
        public string GetCarBrand()
        {
            return "Audi";
        }

        public List<string> GetDetails()
        {
            return new List<string> { "Audi", "R8", "Sports car" };
        }
    }
}
