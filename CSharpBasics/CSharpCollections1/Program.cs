using CSharpCollections1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

ArrayHelper arrayHelper = new ArrayHelper();
Citizen citizen = new Citizen();
DictionaryHelper dictionaryHelper = new DictionaryHelper();


#region Task_1

int[] newArray = arrayHelper.GetIntRandomArray(arrayHelper.GetArraySize());
Console.WriteLine("The origin array:");
arrayHelper.PrintIntArray(newArray);

int[] evenArray = arrayHelper.GetEvenArrayFromRandomArray(newArray);
int[] oddarray = arrayHelper.GetOddArrayFromRandomArray(newArray);

Console.WriteLine("\nThe array with even elements:");
arrayHelper.PrintIntArray(evenArray);

Console.WriteLine("\nThe array with odd elements:");
arrayHelper.PrintIntArray(oddarray);

#endregion

#region Task_2

Console.WriteLine("\nThe array of real number:");
double[] array = arrayHelper.GetDoubleRandomArray(arrayHelper.GetArraySize());
arrayHelper.PrintDoubleArray(array);

Console.WriteLine($"Min value = {arrayHelper.FindMinValueInArray(array)}\n");

Console.WriteLine($"Max value = {arrayHelper.FindMaxValueInArray(array)}\n");

Console.WriteLine($"Difference between max and min = {arrayHelper.FindMaxValueInArray(array) - arrayHelper.FindMinValueInArray(array)}\n");

#endregion

#region Task_3

List<string> surnameList = new List<string> { "Petrov", "Ivanov", "Sydorov", "Ionov", "Platonov", "Yakushev" };
surnameList.Sort();
Console.WriteLine(string.Join(", ", surnameList));
Console.WriteLine();
#endregion

#region Task_4

List<Citizen> citizens = new List<Citizen>();

citizens.Add(new Citizen()
{
    Name = "Vasiliy",
    Patronymic = "Ivanovich",
    Surname = "Pushkin",
    CitizenAddress = new Address("Minsk", "Platonova street", 15, 220116),
    Birthday = new DateTime(2000, 10, 23)
});
citizens.Add(new Citizen()
{
    Name = "Katya",
    Patronymic = "Nikolaevna",
    Surname = "Bykova",
    CitizenAddress = new Address("Minsk", "Kolosa street", 20, 220223),
    Birthday = new DateTime(2004, 11, 07)
});

citizens.Add(new Citizen()
{
    Name = "Semen",
    Patronymic = "Pavlovich",
    Surname = "Kovalev",
    CitizenAddress = new Address("Brest", "Pervomayskaya street", 44, 240223),
    Birthday = new DateTime(2000, 11, 06)
});

citizens.Add(new Citizen()
{
    Name = "Fedor",
    Patronymic = "Nikolaevich",
    Surname = "Bukashka",
    CitizenAddress = new Address("Minsk", "Kolosa street", 20, 220223),
    Birthday = new DateTime(1980, 08, 28)
});
citizens.Add(new Citizen()
{
    Name = "Elena",
    Patronymic = "Alexandrovna",
    Surname = "Pupkina",
    CitizenAddress = new Address("Minsk", "Kolosa street", 20, 220223),
    Birthday = new DateTime(2015, 12, 17)
});

citizen.PrintCitizenList(citizens);

Console.Write("\nEnter street name to select voters by address (ex. kolosa): ");
string nameStreet = Console.ReadLine().ToLower();

Console.Write("\nEnter city name to select voters by full address (ex. minsk): ");
string nameCity = Console.ReadLine().ToLower();

List<Citizen> voterList = citizens
                        .FindAll(x => x.Age(x.Birthday) >= 18)
                        .FindAll(x => x.CitizenAddress.Street.ToLower().Contains(nameStreet) && x.CitizenAddress.City.ToLower().Contains(nameCity));
voterList.Sort((x, y) => x.Name.CompareTo(y.Name));

Console.WriteLine("\nSorted list: ");
citizen.PrintCitizenList(voterList);

#endregion

#region Task_5

Console.Write("\nEnter string numbers and follow to the instruction: ");
var dictionaryList = dictionaryHelper.FillDictionaryList(int.Parse(Console.ReadLine()));

dictionaryHelper.PrintDictionary(dictionaryList);

Console.WriteLine();

var reversDictionaryList = dictionaryHelper.ReversKeyValueDictionary(dictionaryList);

dictionaryHelper.PrintDictionary(reversDictionaryList);

#endregion
