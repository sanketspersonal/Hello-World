using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInterfaces
{
    public interface ICarBrand
    {
        string GetCarBrand();

        List<string> GetDetails();
    }
}
