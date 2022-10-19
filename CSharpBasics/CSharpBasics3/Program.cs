new Homework3().Task_1();
new Homework3().Task_2();
new Homework3().Task_3();
class Homework3
{
    public void Task_1()
    {
        Console.WriteLine("Enter any number");
        bool parseNumber = int.TryParse(Console.ReadLine(), out var number);
        if (parseNumber)
        {
            if (number % 5 == 0 && number % 2 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
            else
            {
                Console.WriteLine("You number isn't divisible by 2 or 5 without a remainder");
            }
        } else
        {
            Console.WriteLine("You entered not number");
        }
    }
    public void Task_2()
    {
        Console.WriteLine("Enter the start number:");
        int startNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the end number:");
        int endNumber = int.Parse(Console.ReadLine());

       
        for (int i = startNumber; i <= endNumber ; i++)
        {
            if (i % 5 == 0 && i % 2 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
            else
            {
                Console.WriteLine($"Number {i} can't be divided by 2 or 5 without a remainder");
            }
        }
    }
    public void Task_3()
    {
        Console.WriteLine("Enter the first number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int lastNumber = int.Parse(Console.ReadLine());

        int minNumber = (firstNumber < lastNumber) ? firstNumber : lastNumber;
        int maxNumber = (firstNumber > lastNumber) ? firstNumber : lastNumber;

        for (int i = minNumber; i <= maxNumber; i++)
        {
            if (i % 5 == 0 && i % 2 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if  (i % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
            else
            {
                Console.WriteLine($"Number {i} can't be divided by 2 or 5 without a remainder");
            }
        }
    }
}
