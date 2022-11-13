using CSharpLinq;
using CSharpOOP2;

LinqHelper linqHelper = new LinqHelper();

#region Task_1

var numbersList = linqHelper.FillCollectionRandomNumber(linqHelper.GetCollectionSize());

linqHelper.PrintCollection(numbersList);

var filterNumbersList = from number in numbersList
                        where number % 3 == 0 && number != 0
                        orderby number
                        select number;

if (filterNumbersList.Any())
{
    Console.WriteLine("\nNew collection includes only numbers that are divided by 3 without remain.");
    Console.Write(string.Join(", ", filterNumbersList));
}
else
{
    Console.WriteLine("\nNew collection doesn't include numbers that are divided by 3 without remain.");
}

Console.WriteLine();

#endregion

#region Task_2

var randomList = new List<int>() { 12, 9, -7, 15, -10, -14, 8, -11, 13, -9 };
linqHelper.PrintCollection(randomList);

var filterRandomList = randomList.Where(x => (x < 0) || (x < 10)).ToList();
linqHelper.PrintCollection(filterRandomList);

#endregion

#region Task_3

Console.Write("\nEnter names or animals or books by comma in one line (ex. Crocodile, Cats, cat, Giraff, Lion, Elephan, turtle, tropical fish): ");

var stringCollection = linqHelper.CreateCollection(Console.ReadLine());

linqHelper.PrintCollection(stringCollection);

var filteredCollection = from name in stringCollection
                         where name.ToUpper().Length % 2 == 0
                         orderby name
                         select name;

Console.Write(string.Join(", ", filteredCollection));
Console.WriteLine();

#endregion

#region Task_4

Console.Write("\nEnter cities by comma in one line (ex. Minsk, Berlin, Praha, Riga, Amsterdam, Ulm, Pusda): ");

var stringCitisCollection = linqHelper.CreateCollection(Console.ReadLine());

linqHelper.PrintCollection(stringCitisCollection);

var filteredCitiesCollection = stringCitisCollection.Where(x => x.ToLower().StartsWith('p') && x.ToLower().EndsWith('a')).ToList();

linqHelper.PrintCollection(filteredCitiesCollection);

#endregion

#region Task_5 

Console.Write("\nEnter any line (ex.Join the large, engaged community of Developers around The globe who build with .NET. Share, showcase, and solve together. Stay connected.): ");

var stringLineCollection = linqHelper.CreateCollection(Console.ReadLine());

linqHelper.PrintCollection(stringLineCollection);

var filterStringLine = stringLineCollection.Where(x => x == x.ToLower()).ToList();

linqHelper.PrintCollection(filterStringLine);

#endregion

#region Task_6

var numbersCollection = new List<int> { 10, 18, 11, 25, 10, 11, 77, 2, 77, 16 };
linqHelper.PrintCollection(numbersCollection);

var newNumbersCollectionWithoutRepits = numbersCollection.Distinct().Reverse().ToList();
linqHelper.PrintCollection(newNumbersCollectionWithoutRepits);

var newNumbersCollectionWithoutRetitsQuery = (from numbers in numbersCollection
                                              select numbers).Distinct().Reverse();

Console.Write(string.Join(", ", newNumbersCollectionWithoutRetitsQuery));
Console.WriteLine();

#endregion

#region Task_7

var numberContainCollection = linqHelper.FillCollectionRandomNumber(linqHelper.GetCollectionSize());
linqHelper.PrintCollection(numberContainCollection);

Console.WriteLine("\nEnter any number to check if it is present in collection: ");

int enteredNumber = int.Parse(Console.ReadLine());

Console.WriteLine(numberContainCollection.Contains(enteredNumber) ? $"The entered number {enteredNumber} is present in the collection" : $"The entered number {enteredNumber} is missing in the collection");

bool isNumberContainsInCollection = (from num in numberContainCollection
                                     select num).Any(num => num == enteredNumber);

Console.WriteLine(isNumberContainsInCollection ? $"The entered number {enteredNumber} is present in the collection" : $"The entered number {enteredNumber} is missing in the collection");

#endregion

#region Task_8 

var linesCollection = new List<string>();

linesCollection.Add("Do you have a big family?");
linesCollection.Add("What makes you feel happy?");
linesCollection.Add("Look at the cartoon.");
linesCollection.Add("Look");

linqHelper.PrintCollection(linesCollection);

var filteredByLengthCollection = linesCollection.Where(x => x.Length > 5).ToList();

var firstLastCollectoinItems = new[] { filteredByLengthCollection.FirstOrDefault(), filteredByLengthCollection.LastOrDefault() }.Where(x => x != null);

var firstLastItems = new[] { filteredByLengthCollection.ElementAtOrDefault(0), filteredByLengthCollection.ElementAtOrDefault(^1) }.Where(x => x != null);

Console.Write(string.Join(", ", firstLastCollectoinItems));

Console.WriteLine();

Console.Write(string.Join(", ", firstLastItems));

#endregion

#region Task_9

Horse horseFirst = new Horse("Penny", "Black", 2, "Belgian", 0.3, true, true, 275);
Horse horseSecond = new Horse("Grosh", "White", 1, "Arabian", 1.3, true, true, 150);
Horse horseThird = new Horse("Monetka", "Grey", 3, "Belgian", 1, true, true, 10);

var horses = new List<Horse> { horseFirst, horseSecond, horseThird };

var horseColor = horses.Select(h => h.Color).ToList();
linqHelper.PrintCollection(horseColor);

var horseColorQuery = from hColor in horses
                      select hColor.Color;
Console.Write(string.Join(", ", horseColorQuery));

var sortedHorses = horses.Select(x => x.NickName).ToList();
linqHelper.PrintCollection(sortedHorses);

var sortNameQuery = from hName in horses
                    select hName.NickName;
Console.Write(string.Join(", ", sortNameQuery));

// create collection of objects from list of NickNames
var newQueryHorse = from objectHorse in sortNameQuery
                    select new Horse 
                    {
                        NickName = objectHorse,
                        Color = "Blue",
                        Age = 2
                    };
foreach (var item in newQueryHorse)
Console.WriteLine($"{item.NickName} - {item.Color} - {item.Age}");

// create collection from list of object
var newHorsesCollection = horses.Select(h => new Horse
{
    NickName = h.NickName,
    Color = h.Color,
    Age = DateTime.Now.Year - h.Age,
}).ToList();

foreach (var item in newHorsesCollection)
    Console.WriteLine($"{item.NickName} - {item.Color} - {item.Age}");

#endregion

#region Task_10

var horsesCollection = new List<Horse> { horseFirst, horseSecond, horseThird };

var newHorsesQuery = from horse in horsesCollection select horse.NickName;
foreach (var item in newHorsesQuery)
{
    Console.WriteLine($"Horse's name is {item}");
}

var newHorseRequest = horsesCollection.Select(x => x.Color).ToList();
linqHelper.PrintCollection(newHorseRequest);

#endregion