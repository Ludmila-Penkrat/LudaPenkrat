// Specific creator / fabric implement the factory method in their own way, producing certain specific products.

using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public class CarDeveloper : IDeveloper
    {
        private int _year;

        public CarDeveloper(int year)
        {
            _year = year;
        }
        public IVehicle Create()
        {
            Car car = new Car(_year);
            return car;
        }
    }
}
