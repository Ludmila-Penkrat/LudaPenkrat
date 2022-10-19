// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Text;

new Homework().Task_1();
new Homework().Task_2();
new Homework().Task_3();
new Homework().Task_4();
new Homework().Task_5();
new Homework().Task_6();
new Homework().Task_7();
new Homework().Task_additional();

new Homework_2().Task_1();
new Homework_2().Task_2();
new Homework_2().Task_3();
new Homework_2().Task_4();
new Homework_2().Task_5();
new Homework_2().Task_6();
new Homework_2().Task_7();
new Homework_2().Task_8();

class Homework

{
    string delimeter = " ";

    public void Task_1()
    {
        int number = 25;
        double result = 100.25;
        char leter = 's';
        bool isLight = true;
        string name = "Luda";
        string surname = "Penkrat";

        Console.WriteLine("Output integer number = " + number);
        Console.WriteLine($"Output double result = {result}");
        Console.WriteLine("Output character leter {0}.", leter);
        Console.WriteLine(isLight);
        Console.WriteLine(string.Concat("Hello", delimeter, name));
        Console.WriteLine(string.Join(" ", name, surname));
    }
    public void Task_2()
    {
        int firstNum = 25;
        int secondNum = 25;

        string street1 = "Levkovo";
        string street2 = "Levkovo";

        Console.WriteLine(firstNum == secondNum);
        Console.WriteLine(secondNum.Equals(firstNum));

        Console.WriteLine(street1 == street2);
        Console.WriteLine(street1.Equals(street2));
        Console.WriteLine("Line street1 is equal line street2: " + string.Compare(street1, street2));
    }
    public void Task_3()
    {
        Console.WriteLine("Input your name, surname and age in format: Luda, Penkrat, 25\n");
        string? line = Console.ReadLine();
        Console.WriteLine("\n" + line);

        string firstDialogeLine = "\"How old are you?\" - policement asked.";
        string secondDialigeLine = "\"23\" - Tom Benenson answered.";

        StringBuilder sb = new StringBuilder();
        sb.Append(firstDialogeLine + "\n");
        sb.Append(secondDialigeLine);
        Console.WriteLine(sb);

    }
    public void Task_4()
    {
        Console.WriteLine("Input four words each of them from new line");
        string? word1 = Console.ReadLine();
        string? word2 = Console.ReadLine();
        string? word3 = Console.ReadLine();
        string? word4 = Console.ReadLine();

        string oneLine = string.Concat(word1, delimeter, word2, delimeter, word3, delimeter, word4);
        Console.WriteLine(oneLine);

        Console.WriteLine(string.Join(" ", word1, word2, word3, word4));
    }
    public void Task_5()
    {
        var newString = Console.ReadLine();
        var updateString = newString[2..];
        var startString = newString.Substring(0, 2);

        Console.WriteLine(string.Join("", startString, updateString));
    }
    public void Task_6()
    {
        Console.WriteLine("Enter a sentence with en adjective: I love my fluffy cat\n");
        var sentense = Console.ReadLine();
        var newAdjective = "bold";
        var newSentense = sentense.Replace("fluffy", newAdjective);
        Console.WriteLine(newSentense);
    }
    public void Task_7()
    {
        Console.WriteLine("Enter any letter\n");
        var lowerLetter = Console.ReadLine().ToLower();
        Console.WriteLine(lowerLetter.ToUpper());
    }
    public void Task_additional()
    {
        StringBuilder sb = new StringBuilder();
        Console.WriteLine("Enter three sentence. Each one is from new line\n");
        sb.Append(Console.ReadLine())
            .Append(delimeter)
            .Append(Console.ReadLine())
            .Append(delimeter)
            .Append(Console.ReadLine());

        Console.WriteLine(sb.ToString());

    }
}

class Homework_2
    {
        IFormatProvider formatter = new NumberFormatInfo
        {
            NumberDecimalSeparator = ".",
        };
    public void Task_1()
    {

        short counter;
        int number;
        double variable;
        char symbol;

        Console.WriteLine("Enter integer to 255: ");
        string? str1 = Console.ReadLine();

        Console.WriteLine("Enter any integer :");
        string? str2 = Console.ReadLine();

        Console.WriteLine("Enter any decimal with dot :");
        string? str3 = Console.ReadLine();

        Console.WriteLine("Enter any character :");
        string? str4 = Console.ReadLine();

        counter = Convert.ToInt16(str1);
        number = Convert.ToInt32(str2);
        variable = Convert.ToDouble(str3, formatter);
        symbol = Convert.ToChar(str4);

        Console.WriteLine($"Counter = {counter}, Number = {number}, Variable = {variable}, Symbol = {symbol}");

    }
    public void Task_2()
    {
        Console.WriteLine("Enter integer a = : ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter decimal with comma d = : ");
        decimal d = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter decimal with dot d = : ");
        decimal difD = decimal.Parse(Console.ReadLine(), formatter);

        Console.WriteLine("Integer a = {0}, decimal d = {1}, decimal difD = {2}", a, d, difD);
    }
    public void Task_3()
    {
        Console.WriteLine("Enter any value: ");
        string? line = Console.ReadLine();

        bool result = int.TryParse(line, out var numberNew);
        if (result)
        {
            Console.WriteLine("You enter integer = {0}", numberNew);
        }
        else
        {
            Console.WriteLine("You input is not correct and there isn't a number.");
        }
    }
    public void Task_4()
    {
        var x = 117;
        var y = x + 3;
        var sum = x + y;
        Console.WriteLine($"\nResult of addition = {sum}");

    }
    public void Task_5()
    {
        var discount = 15;
        int roundValue = 2;

        var books = 11;
        var pansils = 23;
        var notes = 25;
        var types = 103;
        var scissors = 17;

        decimal priceBook = 10.5M;
        decimal pricePansil = 0.25M;
        decimal priceNote = 2M;
        decimal priceType = 1.75M;
        decimal priceScossor = 3.45M;


        decimal total = (books * priceBook) + (pansils * pricePansil) + (notes * priceNote) + (types * priceType) + (scissors * priceScossor);

        decimal sumDiscount = decimal.Round(((total * discount) / 100), roundValue, MidpointRounding.AwayFromZero);

        decimal sumWithDiscount = total - sumDiscount;

        Console.WriteLine($"Your shopping receipt is {total}. \nYour {discount}% discount is {sumDiscount}. \nYour total amount to pay is {sumWithDiscount}.\n");
    }
    public void Task_6()
    {
        double i = 15;
        double k = 11;

        double result1 = (i * k--) / (k * --i);
        /* 1) 15 * 11 =165; k=10
           2) i = 14; 10 * 14 = 140;
           3) 165/140 = 1.1785714286
        */
        Console.WriteLine(result1);

        int c = 5;
        int l = 3;

        int result2 = (--c * (l + c) / c++) % 2;
        /*
         1) --c = 4
         2) l+c = 3 + 4 = 7
         3) --c * (l+c) = 28
         4) 28 / c++ = 28 / 4 = 7, c=5
         5) 7 / 2 = 3, 7 - 6 = остаток = 1
         */
        Console.WriteLine(result2);
    }
    public void Task_7()
    {
        int d = 5;
        int f = 5;
        int g = 5;

        // Result is always true
        Console.WriteLine($"Result is true: {(d == f)}");
        Console.WriteLine($"Result is true: {(d <= f)}");
        Console.WriteLine($"Result is true: {(d != g + 1)}");
        Console.WriteLine($"Result is true: {(d == g && f == g)}");
        Console.WriteLine($"Result is true: {(d == g || f == g)}");
        Console.WriteLine($"Result is true: {(--d <= f)}");
        Console.WriteLine($"Result is true: {(d < f && d < g)}");
        Console.WriteLine($"Result is true: {(d+10 > f || d+10 < g)}");

        Console.WriteLine();

        // Result is always false
        Console.WriteLine($"Result is false: {(g != f)}");
        Console.WriteLine($"Result is false: {(d > f)}");
        Console.WriteLine($"Result is false: {(d == g + 1)}");
        Console.WriteLine($"Result is false: {(++d != g && f == g)}");
        Console.WriteLine($"Result is false: {(d != g || f != g)}");
        Console.WriteLine($"Result is false: {(d < f)}");
        Console.WriteLine($"Result is false: {(d < f && d < g)}");
        Console.WriteLine($"Result is false: {(d + 10 < f || d + 10 < g)}");

    }
    public void Task_8()
    {
        int box = 70;
        object ob = box;
        int unbox = (int)ob; // in the new variable
        box = (int)ob; // in the same variable
    }
    public void Task_9()
    {
        // explicit cast
        int s = 120;
        short s1 = (short)s;

        double s6 = 25.222;
        decimal s7 = (decimal)s6;

        // implicit cast
        int s2 = 1222;
        long s3 = s2;

        float s4 = 2.02f;
        double s5 = s4;
    }
}