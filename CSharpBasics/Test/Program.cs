//int a = Convert.ToInt32(Console.ReadLine());

//for (int i = a; i < 6; i++)
//{
//    Console.WriteLine(i);
//}

//char letter = Convert.ToChar(Console.ReadLine());

//switch (letter)
//{
//    case 'у' or 'е' or 'ё' or 'ы' or 'а' or 'о' or 'я' or 'и' or 'ю':
//        Console.WriteLine("гласная");
//        break;
//    default:
//        break;
//}
//bool isDay = int.TryParse(Console.ReadLine(), out int dayNumber);

//switch (isDay)
//{
//	case true when (dayNumber % 7 == 0):
//        Console.WriteLine("Воскресенье");
//		break;
//    case true when (dayNumber % 7 == 6):
//        Console.WriteLine("Суббота");
//        break;
//    case true when (dayNumber % 7 == 5):
//        Console.WriteLine("Пятница");
//        break;
//    case true when (dayNumber % 7 == 4):
//        Console.WriteLine("Четверг");
//        break;
//    case true when (dayNumber % 7 == 3):
//        Console.WriteLine("Среда");
//        break;
//    case true when (dayNumber % 7 == 2):
//        Console.WriteLine("Вторник");
//        break;
//    case true when (dayNumber % 7 == 1):
//        Console.WriteLine("Понедельник");
//        break;

//    default:
//		break;
//}

//Console.WriteLine("Введите два числа через пробел: длина и ширина участка");
//string line = Console.ReadLine();
//string[] splitString = line.Split(' ');

//double length = Convert.ToDouble(splitString[0]); // длина
//double width = Convert.ToDouble(splitString[1]); // ширина
//double landArea = 0;   // переменная для площади





////Тут будет Ваш код
//Console.WriteLine($"Площадь участка: {landArea}");


/*Введите два числа через пробел: длина и ширина участка
Площадь участка: 793.28
length and width

*/

int levels = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Points(levels));

static int Points(int levels)
{
    if(levels == 1)
    {
        return 1;
    }
   return Points(levels - 1)+levels;
}