using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsInterfaces
{
    public interface ICarsRepository
    {
        List<string> GetCarDetails(string CarBrand);
    }
}
