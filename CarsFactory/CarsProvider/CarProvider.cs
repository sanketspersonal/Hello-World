using CarsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProvider
{
    public class CarProvider : ICarsProvider
    {
        ICarsRepository _carsRepository;
        public CarProvider(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }

        public List<string> GetCarDetails(string CarBrand)
        {
            return _carsRepository.GetCarDetails(CarBrand);
        }
    }
}
