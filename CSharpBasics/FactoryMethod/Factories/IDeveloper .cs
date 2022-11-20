//Creator / Fabric. Creator contains fabric method that will be returned new product object.

using FactoryMethod.Products;

namespace FactoryMethod.Factories
{
    public interface IDeveloper
    {
        public IVehicle Create();
    }
}
