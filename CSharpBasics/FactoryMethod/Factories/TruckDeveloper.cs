// Specific creator / fabric implement the factory method in their own way, producing certain specific products.

using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public class TruckDeveloper : IDeveloper
    {
        private int _year;

        public TruckDeveloper(int year)
        {
            _year = year;
        }
        public IVehicle Create()
        {
            Truck truck = new Truck(_year);
            return truck;
        }
    }
}
