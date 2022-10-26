#region Task_1

Console.WriteLine("Enter count of items(3):");
bool isItemNumber = decimal.TryParse(Console.ReadLine(), out decimal items);

Console.WriteLine("Enter item price:");
bool isItemPriceNumber = decimal.TryParse(Console.ReadLine(), out decimal itemPrice);

Console.WriteLine("Enter general discount:");
bool DiscountNumber = decimal.TryParse(Console.ReadLine(), out decimal discount);

decimal result = new Homework_1().countTotalPriceWithDiscount(items, itemPrice, discount);
Console.WriteLine($"Total sum with discount = {result}\n");

#endregion

#region Task_2
Console.WriteLine("Enter three position names in one line by space:");
string? nameOfPositions = Console.ReadLine();

Console.WriteLine("Enter three price per item in one line by space:");
string? priceForEachPositions = Console.ReadLine();

decimal positionResult = new Homework_1().countTotalPriceWithDiscount(new Homework_1().createItemsList(nameOfPositions),
                        new Homework_1().createItemsPriceList(priceForEachPositions), discount, items);
Console.WriteLine($"Total resal for all position with discount = {positionResult} EUR\n");

#endregion

#region Task_3
decimal totalResultWithoutOptionalArg = new Homework_1().countTotalPriceWithDiscount(new Homework_1().createItemsList(nameOfPositions), new Homework_1().createItemsPriceList(priceForEachPositions), discount);
Console.WriteLine($"Total resal for all position with discount = {totalResultWithoutOptionalArg} EUR");

Console.WriteLine();

decimal totalResultWithOptionalArg = new Homework_1().countTotalPriceWithDiscount(new Homework_1().createItemsList(nameOfPositions), new Homework_1().createItemsPriceList(priceForEachPositions), discount, items);
Console.WriteLine($"Total resal for all position with discount = {totalResultWithOptionalArg} EUR");
#endregion

#region Task_4

Console.WriteLine("Enter five numbers:");
double sideOne = double.Parse(Console.ReadLine());
double sideTwo = double.Parse(Console.ReadLine());
double sideThree = double.Parse(Console.ReadLine());
double sideFour = double.Parse(Console.ReadLine());
double sideFive = double.Parse(Console.ReadLine());

double trianglePerimeter = new Homework_1().perimeterCalculation(sideOne, sideTwo, sideThree);
double rectanglePerimeter = new Homework_1().perimeterCalculation(sideOne, sideTwo, sideOne, sideTwo);
double quadrilateralPerimeter = new Homework_1().perimeterCalculation(sideOne, sideTwo, sideThree, sideFive);
double pentagonPerimeter = new Homework_1().perimeterCalculation(sideOne, sideTwo, sideThree, sideFour, sideFive);

Console.WriteLine($"Triangle perimeter is {trianglePerimeter}. " +
    $"\nRectangle perimeter is {rectanglePerimeter}. " +
    $"\nQuadrilateral perimeter is {quadrilateralPerimeter}." +
    $"\nPentagon perimeter is {pentagonPerimeter} ");

#endregion

#region Task_5

double areaCirclResult = new Homework_1().areaCalculation(2.5);
Console.WriteLine(areaCirclResult);

double areaTreangelCalculation = new Homework_1().areaCalculation(new Homework_1().perimeterCalculation(sideOne, sideTwo, sideThree), sideOne, sideTwo, sideThree);
Console.WriteLine(areaTreangelCalculation);
#endregion



public class Homework_1
{
    public int roundValue = 2;

    public decimal countTotalPriceWithDiscount(decimal items, decimal itemPrice, decimal discount)
    {
        decimal totalPrice = Decimal.Round((items * itemPrice), roundValue, MidpointRounding.AwayFromZero);
        decimal discountSum = Decimal.Round((totalPrice * (discount / 100)), roundValue, MidpointRounding.AwayFromZero);
        decimal totalSumWithDiscount = totalPrice - discountSum;

        return totalSumWithDiscount;
    }

    public decimal countTotalPriceWithDiscount(string[] itemName, decimal[] itemPrice, decimal discount, decimal items=5)
    {
        decimal totalSumForAllPositionsWithDiscount = 0;
        for (int i = 0; i < itemName.Length; i++)
        {
            for (int j = i; j < itemPrice.Length; j++)
            {
                if(j >i )
                {
                    break;
                }
                totalSumForAllPositionsWithDiscount += countTotalPriceWithDiscount(items, itemPrice[j], discount);
                Console.WriteLine($"For position {itemName[i]} with position price {itemPrice[j]}EUR and count {items}pcs. minus discount {discount}% " +
                    $"total price with discount is {countTotalPriceWithDiscount(items, itemPrice[j], discount)}EUR");
            }

        }
        return totalSumForAllPositionsWithDiscount;
    }

    public double perimeterCalculation(params double[] sideLenght)
    {
        double perimeter = 0;
        foreach (double side in sideLenght)
        {
            perimeter += side;
        }
        return perimeter;
    }

    public double areaCalculation(double radius)
    {
        double circleArea = Math.Pow(radius, 2) * Math.PI;
        return Math.Round(circleArea, roundValue, MidpointRounding.AwayFromZero);
    }

    public double areaCalculation(double perimeter, params double[] triangleSides)
    {
        double count = 1;
        foreach (var item in triangleSides)
        {
            count *= (perimeter / 2) - item;
        }
        double triangelArea = Math.Sqrt((perimeter/2) * count);

        return Math.Round(triangelArea, roundValue, MidpointRounding.AwayFromZero);
    }

    public string[] createItemsList(string positionNames)
    {
        string[] itemsArray = positionNames.Trim().Split(" ");

        return itemsArray;

    }
    public decimal[] createItemsPriceList(string priseForEachPositions)
    {
        string[] itemsPriceArray = priseForEachPositions.Trim().Split(" ");
        decimal[] itemPriceArray = new decimal[itemsPriceArray.Length];

        for (int i = 0; i < itemsPriceArray.Length; i++)
        {
            for (int j = i; j < itemsPriceArray.Length; j++)
            {
                if (j > i)
                {
                    break;
                }
                itemPriceArray[j] = decimal.Parse(itemsPriceArray[i]);
            }
        }

        return itemPriceArray;

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