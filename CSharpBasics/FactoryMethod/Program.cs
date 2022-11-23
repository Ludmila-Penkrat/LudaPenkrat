using FactoryMethod.Products;
using FactoryMethod.Factories;

Console.WriteLine("Welcom to Vehicle shop!\n");

Console.WriteLine("Enter the type of vehicle that you want to buy: ");

Console.WriteLine("C - car");
Console.WriteLine("U - unicycle");
Console.WriteLine("M - Motorbike");
Console.WriteLine("T - Truck");

bool IsIncorrectEnter;

do
{
    try
    {
        string vehecleType = Console.ReadLine();

        IDeveloper developer = GetFactory(vehecleType);
        IVehicle vehicle = developer.Create();
        vehicle.GetInfo();

        IsIncorrectEnter = false;
    }
    catch(NullReferenceException ex)
    {
        IsIncorrectEnter = true;
        Console.WriteLine(ex.Message);
    }
} while (IsIncorrectEnter);

static IDeveloper GetFactory(string vehecleType)
{
     switch (vehecleType.ToUpper())
     {
        case "C":
            return new CarDeveloper(2020);
        case "T":
            return new TruckDeveloper(2022);
        case "U":
            return new UnicycleDeveloper(2019);
        case "M":
            return new MotorbikeDeveloper(2017);
        default:
            throw new NullReferenceException("You entered incorrect value. Try again.");
     }
}