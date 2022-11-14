namespace CSharpLinq
{
    public class LinqHelper
    {
        Random random = new Random();

        char[] SPLITERATOR = new[] { ' ', '.', ',', '\n', '\t', '\r', '\v'};
        public const string DELIMETER = ", ";

        public int GetCollectionSize()
        {
            Console.Write("\nEnter collection size: ");
            return int.Parse(Console.ReadLine());
        }

        public List<int> FillCollectionRandomNumber(int size)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(-100, 100));
            }
            return list;
        }

        public List<string> CreateCollectionFromSentence(string line)
        {
            string[] newLine = line.Split(SPLITERATOR.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
            for (int i = 0; i < newLine.Length; i++)
            {
                list.Add(newLine[i]);
            }
            return list;
        }

        public List<string> CreateCollection(string line)
        {
            string[] newLine = line.Split(DELIMETER);
            List<string> list = new List<string>();
            for (int i = 0; i < newLine.Length; i++)
            {
                list.Add(newLine[i]);
            }
            return list;
        }

        public void PrintCollection(List<int> list)
        {
            Console.Write(string.Join(DELIMETER, list));
            Console.WriteLine();
        }

        public void PrintCollection(List<string> list)
        {
            Console.Write(string.Join(DELIMETER, list));
            Console.WriteLine();
        }
    }
}
