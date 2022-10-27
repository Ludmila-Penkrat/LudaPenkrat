#region Task_1

Console.WriteLine("Enter number of items:");
bool isItemNumber = decimal.TryParse(Console.ReadLine(), out decimal numberOfItems);

Console.WriteLine("Enter item price:");
bool isItemPriceNumber = decimal.TryParse(Console.ReadLine(), out decimal itemPrice);

Console.WriteLine("Enter general discount:");
bool DiscountNumber = decimal.TryParse(Console.ReadLine(), out decimal discount);

decimal result = new Homework_1().СountTotalPriceWithDiscount(numberOfItems, itemPrice, discount);
Console.WriteLine($"Total sum with discount = {result}\n");

#endregion

#region Task_2
int count = 0;
while (count < 3)
{

    Console.WriteLine("Enter a position name:");
    string? nameOfPositions = Console.ReadLine();

    Console.WriteLine("Enter price per item:");
    decimal priceForEachPositions = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Enter number of items:");
    decimal number = decimal.Parse(Console.ReadLine());

    new Homework_1().CountTotalPriceWithDiscount(nameOfPositions, priceForEachPositions, discount, number);

    count++;
}
Console.WriteLine();

#endregion

#region Task_3
new Homework_1().CountTotalPriceWithDiscount(itemName: "Pencil", itemPrice: 5.25M, discount);

new Homework_1().CountTotalPriceWithDiscount(itemName: "Pen", itemPrice: 1.05M, discount, 7);

Console.WriteLine();
#endregion

#region Task_4

Console.WriteLine("Enter five numbers:");
double sideOne = double.Parse(Console.ReadLine());
double sideTwo = double.Parse(Console.ReadLine());
double sideThree = double.Parse(Console.ReadLine());
double sideFour = double.Parse(Console.ReadLine());
double sideFive = double.Parse(Console.ReadLine());

double trianglePerimeter = new Homework_1().PerimeterCalculation(sideOne, sideTwo, sideThree);
double rectanglePerimeter = new Homework_1().PerimeterCalculation(sideOne, sideTwo, sideOne, sideTwo);
double quadrilateralPerimeter = new Homework_1().PerimeterCalculation(sideOne, sideTwo, sideThree, sideFive);
double pentagonPerimeter = new Homework_1().PerimeterCalculation(sideOne, sideTwo, sideThree, sideFour, sideFive);

Console.WriteLine($"Triangle perimeter is {trianglePerimeter}. " +
    $"\nRectangle perimeter is {rectanglePerimeter}. " +
    $"\nQuadrilateral perimeter is {quadrilateralPerimeter}." +
    $"\nPentagon perimeter is {pentagonPerimeter} ");

Console.WriteLine();

#endregion

#region Task_5

double areaCirclResult = new Homework_1().AreaCalculation(2.5);
Console.WriteLine($"The area of circle is: {areaCirclResult}");

double areaTreangelCalculation = new Homework_1().AreaCalculation(new Homework_1().PerimeterCalculation(sideOne, sideTwo, sideThree), sideOne, sideTwo, sideThree);
Console.WriteLine($"The area of triangle is: {areaTreangelCalculation}");
#endregion



public class Homework_1
{
    public int roundValue = 2;

    public decimal СountTotalPriceWithDiscount(decimal numberOfItems, decimal itemPrice, decimal discount)
    {
        decimal totalPrice = Decimal.Round((numberOfItems * itemPrice), roundValue, MidpointRounding.AwayFromZero);
        decimal discountSum = Decimal.Round((totalPrice * (discount / 100)), roundValue, MidpointRounding.AwayFromZero);
        decimal totalSumWithDiscount = totalPrice - discountSum;

        return totalSumWithDiscount;
    }

    public void CountTotalPriceWithDiscount(string itemName, decimal itemPrice, decimal discount, decimal numberOfItems = 5)
    {
        decimal totalSumForAllPositionsWithDiscount = СountTotalPriceWithDiscount(numberOfItems, itemPrice, discount);

        Console.WriteLine($"For position {itemName} with position price {itemPrice}EUR and count {numberOfItems}pcs. minus discount {discount}% " +
                    $"total price with discount is {totalSumForAllPositionsWithDiscount}EUR");
    }

    public double PerimeterCalculation(params double[] sideLenght)
    {
        double perimeter = 0;
        foreach (double side in sideLenght)
        {
            perimeter += side;
        }
        return perimeter;
    }

    public double AreaCalculation(double radius)
    {
        double circleArea = Math.Pow(radius, 2) * Math.PI;
        return Math.Round(circleArea, roundValue, MidpointRounding.AwayFromZero);
    }

    public double AreaCalculation(double perimeter, params double[] triangleSides)
    {
        double count = 1;
        foreach (var item in triangleSides)
        {
            count *= (perimeter / 2) - item;
        }
        double triangelArea = Math.Sqrt((perimeter/2) * count);

        return Math.Round(triangelArea, roundValue, MidpointRounding.AwayFromZero);
    }
}

/* Инкапсуляция - любой гаджет, который мы используем (робот-пылесос). Ты знаешь как включить, куда нажать и что он делает.
 * Но что происходит под капотом (как он всасывает пыль, ориентируется в пространстве, брызгает водой) тебя не интересует, потому как и без этих знаний он будет работать
 * 
 * Полиморфизм - руль автомобиля. Если ты знаешь как обращаться с рулем, то ты можешь с помощью него управлять автомобилем не зависимо от того
 * зубчатая, реечная передача, гидро- или электроусилитель используется в конструкции автою
 * 
 * Наследование - от общего к частному. Определнный сорт яблок относится к более общему "яблоки в целом". Яблоки это фрукты. Фрукты это продукты питания. 
 * Проукт питания - съедобный, калорийный, сырой, готоый) --> Фрукт наследует все от продукта питания и получает новые свойства (сладкий, сочный, спелый, неспелый, гнилой..)
 * --> Яблоко наследует все от продуктов питания и фруктов и имеет свои свойства (растет на дереве, не тропический, сезонный) --> Определенный сорт яблока наследует все и имеет 
 * частные характеристики (размер, цвет, срок хранения, срок созревания..).
 * 
 * Абстракция - выделение наиболее значимых и часто используемых свойств предмета. Возможно мобильный телефон - сделать звонок, написать сообщение,
 * прочитать новости, поискать информацию. Наиболее часто используемые операции. Но есть еще куча всего о чем мы не задумываемся: например корпус телефона,
 * из какого материала кнопки, сколько пиксилей камера и т.д.
*/    