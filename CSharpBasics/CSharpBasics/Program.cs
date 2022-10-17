// See https://aka.ms/new-console-template for more information

using System.Text;

new Homework().Task_1();
new Homework().Task_2();
new Homework().Task_3();
new Homework().Task_4();
new Homework().Task_5();
new Homework().Task_6();
new Homework().Task_7();
new Homework().Task_additional();

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