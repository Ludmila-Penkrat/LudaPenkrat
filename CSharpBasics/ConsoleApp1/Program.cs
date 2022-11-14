//Person[] people =
//{
//    new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
//    new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
//    new Person("Kate", "JetBrains"), new Person("Alice", "Microsoft"),
//};

//var companies = from person in people
//                group person by person.Company into g
//                select new { Name = g.Key, Count = g.Count() }; ;

//foreach (var company in companies)
//{
//    Console.WriteLine($"{company.Name} : {company.Count}");
//}

//record class Person(string Name, string Company);


Person[] people =
{
    new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
    new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
    new Person("Kate", "JetBrains"), new Person("Alice", "Microsoft"),
};

var companies = people.GroupBy(p => p.Company);

foreach (var company in companies)
{
    Console.WriteLine(company.Key);

    foreach (var person in company)
    {
        Console.WriteLine(person.Name);
    }
    Console.WriteLine(); // для разделения между группами
}

record class Person(string Name, string Company);
