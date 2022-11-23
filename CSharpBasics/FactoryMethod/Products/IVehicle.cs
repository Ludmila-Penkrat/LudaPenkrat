// Product that a creator can produce.

namespace FactoryMethod.Products
    {
    public interface IVehicle
    {
        string Name { get; }
        int Year { get; set; }

        void GetInfo();
    }
}
