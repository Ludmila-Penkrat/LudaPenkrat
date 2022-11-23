// Specific product that have difference in implementation from another product, but has a common interface.


namespace FactoryMethod.Products
{
    public class Car : IVehicle
    {
        private string _name;
        private int _year;

        public Car(int year)
        {
            _name = "Car";
            _year = year;
        }

        public string Name => _name;

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public void GetInfo()
        {
            Console.WriteLine($"You have chosen {_name} manufactured in {_year}.");
        }
    }
}
