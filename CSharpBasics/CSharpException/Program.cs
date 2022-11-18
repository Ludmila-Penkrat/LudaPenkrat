using CSharpException;

Triangle triangle = new Triangle();
bool IsCorrectValue = false;
double firstSide = 0;
double secondSide = 0;
double thirdSide = 0;
int count = 1;

do
{
    try
    {
        if(count == 1)
        {
            Console.WriteLine($"Enter size for {count} triangle side");
            firstSide = triangle.GetTriangleSide(Console.ReadLine());
            count++; 
        }
        if (count == 2)
        {
            Console.WriteLine($"Enter the size for {count} triangle side");
            secondSide = triangle.GetTriangleSide(Console.ReadLine());
            count++;
        }
        if (count == 3)
        {
            Console.WriteLine($"Enter the size for {count} triangle side");
            thirdSide = triangle.GetTriangleSide(Console.ReadLine());
            count++;
        }
        Console.WriteLine();
    }
    catch (TriangleException ex)
    {
        IsCorrectValue = true;
        Console.WriteLine(ex.Message);
    }
    catch(FormatException ex)
    {
        IsCorrectValue = true;
        Console.WriteLine(ex.Message);
    }
}while (IsCorrectValue && count < 4);

try
{
    if (triangle.IsLengthTriangleSide(firstSide, secondSide, thirdSide))
    {
        double result = triangle.TriangleSquare(firstSide, secondSide, thirdSide);
        Console.WriteLine($"Triangle area is {result}");
    }
} 
catch(TriangleException ex)
    {
    Console.WriteLine(ex.Message);
    }







/*Реализуйте ввод длин сторон с клавиатуры. 
 * Реализуйте обработку собственных классов исключений, 
 * которые могут возникнуть при вводе значений с клавиатуры, взяв за основу следующие правила: 

- Любая сторона треугольника меньше суммы двух других сторон. 
Выброс исключения, связанного с нарушением этого условия, 
должен приводить к завершению работы программы с выводом соответствующего сообщения. 

- Значение ни одной из сторон не может быть равно нулю. 
Выброс исключения, связанного с нарушением этого условия, 
должен приводить запросу на повторный ввод значения стороны. 
*/