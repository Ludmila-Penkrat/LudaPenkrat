using Decorator;

IGigantosaurus dinosaurusWithoutDecorator = new Gigantosaurus("Petya");
Console.WriteLine(dinosaurusWithoutDecorator.Roar());

Console.WriteLine("-------------------------------------");

IGigantosaurus dinosaurus = new Gigantosaurus("Vova");

IDenosaurusDecorator denosaurusDecorator = new LoudGigantosarusDecorator(dinosaurus);
Console.WriteLine(denosaurusDecorator.Roar());
denosaurusDecorator.SetComponent(dinosaurus);

Console.WriteLine("-------------------------------------");


IGigantosaurus gigantosurus = new Gigantosaurus("Vasya");

IDenosaurusDecorator gigantosaurusDecorator = new ExtraLoudGigantosaurusDecorator(gigantosurus);
Console.WriteLine(gigantosaurusDecorator.Roar());
gigantosaurusDecorator.SetComponent(gigantosurus);

Console.WriteLine("-------------------------------------");

IGigantosaurus newDinosurusWithTwoDecorator = new Gigantosaurus("Maxim");
var secondDecorator = new ExtraLoudGigantosaurusDecorator(new LoudGigantosarusDecorator(newDinosurusWithTwoDecorator));

Console.WriteLine(secondDecorator.Roar());

secondDecorator.SetComponent(newDinosurusWithTwoDecorator);

var result = Sqrt(6.25);
Console.WriteLine(result);

static double Sqrt(object a)
{
    var b = Convert.ToInt32(a);
    return Math.Sqrt(b);
}