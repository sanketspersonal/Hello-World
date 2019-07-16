using CarsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolutions
{
    public class CarsObjectBinding
    {
        private static Dictionary<string, ICarBrand> CarBrandList = new Dictionary<string, ICarBrand>();

        public static void InitializeTypes(List<Type> types)
        {
            foreach (var type in types)
            {
                try
                {
                    if (type.GetInterface("ICarBrand") != null)
                    {
                        ICarBrand carBrand = Activator.CreateInstance(type) as ICarBrand;
                        CarBrandList.Add(carBrand.GetCarBrand(), carBrand);
                    }
                }
                catch (Exception ex)
                { }
            }
        }

        public static ICarBrand GetTypeObject(string key)
        {
            if (!CarBrandList.ContainsKey(key))
                throw new ApplicationException("Brand not found");

            ICarBrand applicableBrand = CarBrandList[key];
            if (applicableBrand == null)
                throw new ApplicationException("Brand not found");
            return applicableBrand;
        }
    }

    public class AppsObjectsBinding
    {
        public static void InitializeTypes(List<Type> types)
        {
            foreach (var type in types)
            {
                try
                {
                    ICarBrand carBrand = Activator.CreateInstance(type) as ICarBrand;
                }
                catch (Exception ex)
                { }
            }
        }
    }
}
