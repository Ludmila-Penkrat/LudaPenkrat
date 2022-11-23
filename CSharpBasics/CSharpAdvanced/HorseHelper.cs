using CSharpAdvanced;
using System.Text;

namespace CSharpOOP2
{
    public static class HorseHelper
    {
        public static void PrintBasicHorseDescription(this Horse horse)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name of your horse is {horse.NickName}\n")
                .Append($"Color of your horse is {horse.Color}\n")
                .Append($"Breed of your hourse is {horse.Breed}\n")
                .Append($"Age is {horse.Age}\n");
            Console.WriteLine(sb);
        }
        public static void AddorChangeColor(this Horse horse, string newColor)
        {
            horse.Color = newColor;
        }
        public static double CalculateHourseAgeByTailLength(this Horse horse)
        {

            if (horse.TailLength > 0 && horse.TailLength <= 0.5)
            {
                return horse.Age = 1;
            }
            else if (horse.TailLength > 0.5 && horse.TailLength <= 1)
            {
                return horse.Age = 2;
            }
            else if (horse.TailLength > 1 && horse.TailLength <= 2)
            {
                return horse.Age = 3;
            }
            else
            {
                return horse.Age = 4;
            }
        }

        public static List<T> GetHorseWithLongName<T>(this List<T> horses) where T : Horse
        {
            return horses.Where(x => x.NickName.Length > 4).ToList();
        }

        public static void PrintCollection(this List<Horse> list) 
        {
            foreach (var item in list)
            {
                item.PrintBasicHorseDescription();

            }
        }
    }
}