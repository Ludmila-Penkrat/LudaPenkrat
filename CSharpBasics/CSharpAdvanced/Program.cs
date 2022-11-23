#region Task_1

using CSharpAdvanced;
using CSharpOOP2;
using System;

int[] intArray = new int[] { 111, 25, -25, 56, 58, 777 };
string[] stringArray = new string[] { "book", "door", "floor", "car" };
decimal[] decimalArray = new decimal[] { 2.22m, 5.123m, 125.21m, 777.235m };

Console.WriteLine(GetFirstElement(intArray));
Console.WriteLine(GetFirstElement(stringArray));
Console.WriteLine(GetFirstElement(decimalArray));

static T GetFirstElement<T>(T[] item)
{
    return item.FirstOrDefault();
}

#endregion

#region Task_2

Chamomile chamomile = new Chamomile("Sun", "White", 0.25m);
Rose rose = new Rose("Beatris", "Bordo", 1.11m);

Console.Write("Enter number of roses : ");
int rosesCount = int.Parse(Console.ReadLine());

Console.Write("Enter number of chamomiles : ");
int chamomilesCount = int.Parse(Console.ReadLine());

Console.WriteLine($"\nFinal check for flowers: {Calculation.GetCheck(rose, rosesCount)}");

Console.WriteLine($"\nFinal check for flowers: {Calculation.GetCheck(chamomile, chamomilesCount)}");

#endregion

#region Task_3

var newChamomile = UpgradeFlowers<Flower>.RepaintFlower(chamomile);
Console.WriteLine($"\nNew total price after recalculation: {Calculation.GetCheck(newChamomile, chamomilesCount)}");

var newRose = UpgradeFlowers<Flower>.RepaintFlower(rose);
Console.WriteLine($"\nNew total price after recalculation: {Calculation.GetCheck(newRose, rosesCount)}");

#endregion

#region Task_4

Horse horseFirst = new Horse("Blansh", "White", 1, "Belarusian harness", 1.0);
Console.WriteLine("\nPrint horse parameter using extention method: ");
horseFirst.PrintBasicHorseDescription();

Horse horseSecond = new Horse("Cloun", "Black", 2, "Belarusian harness", 0.5);
Horse horseThird = new Horse("Bar", "In Spots", 3, "Belarusian harness", 1.5);

Console.Write("\nAdd new color: ");
var newColor = Console.ReadLine();
var horseWithNewColor = (Horse)horseFirst.Clone();
horseWithNewColor.AddorChangeColor(newColor);


Console.WriteLine("\nPrint horse parameter using extention method(changing color): ");
horseWithNewColor.PrintBasicHorseDescription();

Console.WriteLine($"\nAge of your horse after calculation according tail length {horseWithNewColor.TailLength} meter is: {horseWithNewColor.CalculateHourseAgeByTailLength()}");

var horseList = new List<Horse>() { horseFirst, horseSecond, horseThird };
var newListOfHorses = horseList.GetHorseWithLongName();

Console.WriteLine("\nPrint collection of horses after filtering by name longer then 4 characters: ");
newListOfHorses.PrintCollection();

#endregion