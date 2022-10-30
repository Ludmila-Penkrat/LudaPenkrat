using CSharpOOP2;


#region Task_4
Horse horse1 = new Horse();
horse1.NickName = "Rose";
horse1.Color = "Brown";
horse1.Age = 2;
horse1.Breed = "Arabic";
horse1.TailLength = 1.2;
horse1.IsVaccinated = true;
horse1.IsHealthy= true;
horse1.DaysNumberLastVaccination = 78;
#endregion

#region Task_5

Horse horse2 = new Horse() { NickName = "Blansh", Color = "White", Age = 1, Breed = "Belarusian harness", TailLength = 1.0, IsVaccinated = true, IsHealthy = true, DaysNumberLastVaccination = 155 };

#endregion

#region Task_9

Horse horseAllFields = new Horse("Grosh", "Black", 2.5, "Belgian", 0.3, true, true, 275);

#endregion

#region Task_10

bool result = horse1.NeedDoVaccination(375);
Console.WriteLine(result);
horse1.TakePartInTournaments(result, horse1.IsVaccinated);

#endregion

#region Task_11

// with internal modifier
horse2.CheckVaccination(horse2.Age);

// with private modifier
//horse2.CutTail(horse2.TailLength); Error Line

#endregion

#region Task_12

Horse horseWithoutFields = new Horse();
//horseWithoutFields.NickName = "Rose";
horseWithoutFields.Color = "Brown";
//horseWithoutFieldAge.Age = 2;
//horseWithoutFields.Breed = "Arabic";
horseWithoutFields.TailLength = 1.2;
//horseWithoutFieldAge.IsVaccinated = true;
//horseWithoutFieldAge.IsHealthy = true;
horseWithoutFields.DaysNumberLastVaccination = 78;

horseWithoutFields.CheckVaccination(horseWithoutFields.Age); //this method is executed without error because the default value for double = 0.
horseWithoutFields.TakePartInTournaments(horseWithoutFields.IsVaccinated, horseWithoutFields.IsHealthy); //this method is executed without error because the default value for bool is false
horseWithoutFields.PrintParticipantGreeting(horseWithoutFields.NickName, horseWithoutFields.Breed); // this method is executed without error but with the empty valu for missing parameters (Welcome the next participant of tournament <> of the <>  breed)

#endregion

#region Task_13

Horse horsDefaultValueAge = new Horse();
horsDefaultValueAge.NickName = "Brige";
Console.WriteLine($"There is new instanse of Horse class with nickname {horsDefaultValueAge.NickName} has {horsDefaultValueAge.NumbersOfWins} wins.");

Console.WriteLine();
#endregion

#region Task_15
Horse horseChechProperty = new Horse();
horseChechProperty.Speed = 15;
// Console.WriteLine(horseChechProperty.Speed); Error Line

// horseChechProperty.IsReadyToCompetition = true;  Error Line
Console.WriteLine($"This horse can take part in competition: if {horseChechProperty.IsReadyToCompetition} = true - \"Yes\" if {horseChechProperty.IsReadyToCompetition} = false - \"No\"");

Console.WriteLine();
#endregion

#region Task_17
Console.WriteLine("Use static propertiy");

Console.WriteLine($"Kind of our animal is {Horse.Kind}");
Horse.Kind = "New Horse";
Console.WriteLine($"Now we change animal to {Horse.Kind}");

Console.WriteLine();
#endregion

#region Task_18
Console.WriteLine("Enter number of jockeys");
int numberOfJockeys = int.Parse(Console.ReadLine());

Console.WriteLine(Horse.CheckHorseTrainigOrCompetition(numberOfJockeys));
Console.WriteLine();
#endregion

#region Task_20
HorseHelper.PrintBasicHorseDescription(horse1);

HorseHelper.AddorChangeColor(horsDefaultValueAge, "Blue");
HorseHelper.PrintBasicHorseDescription(horsDefaultValueAge);

Console.WriteLine($"Age of horse is {HorseHelper.CalculateHourseAgeByTailLength(horse2)}");

#endregion