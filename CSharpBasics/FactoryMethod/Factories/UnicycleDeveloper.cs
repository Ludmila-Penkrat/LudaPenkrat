// Specific creator / fabric implement the factory method in their own way, producing certain specific products.

using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public class UnicycleDeveloper : IDeveloper
    {
        private int _year;

        public UnicycleDeveloper(int year)
        {
            _year = year;
        }
        public IVehicle Create()
        {
            Unicycle unicycle = new Unicycle(_year);
            return unicycle;
        }
    }
}
