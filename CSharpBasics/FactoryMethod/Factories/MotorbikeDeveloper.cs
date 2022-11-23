// Specific creator / fabric implement the factory method in their own way, producing certain specific products.

using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public class MotorbikeDeveloper : IDeveloper
    {
        private int _year;

        public MotorbikeDeveloper(int year)
        {
            _year = year;
        }
        public IVehicle Create()
        {
            Motorbike motorbike = new Motorbike(_year);
            return motorbike;
        }
    }
}
