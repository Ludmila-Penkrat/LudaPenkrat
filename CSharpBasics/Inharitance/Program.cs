using Inharitance.InterfaceAbstractClass;

#region Interface + abstract class

Cat cat = new Cat("Barsik");
cat.GetInfo();
cat.MakeSound();
cat.Move();

Dog dog = new Dog("Arrow");
dog.GetInfo();
dog.MakeSound();
dog.Move();

Kangaroo kangaroo = new Kangaroo("Jumpunch");
kangaroo.GetInfo();
kangaroo.MakeSound();
kangaroo.Move();

#endregion

#region Collection

var newChar = 'Q';
var cities = new List<string> { "Minsk", "Praha", "Berlin", "Molodechno" };

var newCitiesList = cities.Where(x => x.Length%2 == 0).Select(x => x.Replace(x.First(), newChar)).Select(x => x.Substring(0,3)).ToList();

Console.WriteLine(String.Join(", ", newCitiesList));

#endregion

#region Generic method

void PrintItem<T>(T item)
{
    Console.WriteLine(item);
}

PrintItem(newChar);
PrintItem("new York");
PrintItem(20);
PrintItem(20.25M);
PrintItem(0.25f);

#endregion