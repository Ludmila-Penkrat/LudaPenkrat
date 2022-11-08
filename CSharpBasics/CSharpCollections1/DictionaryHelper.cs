using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections1
{
    public class DictionaryHelper
    {
        public Dictionary<string, string> FillDictionaryList(int countElement)
        {
            Dictionary<string, string> list = new Dictionary<string, string>();
            for (int i = 0; i < countElement; i++)
            {
                Console.WriteLine($"\nEnter {i+1} string in the following format: Country : Capital");
                string[] lines = Console.ReadLine().Split(" : ");
                list.Add(lines[0], lines[1]);
            }
            return list;
        }

        public Dictionary<string, string> ReversKeyValueDictionary(Dictionary<string, string> originDictionary)
        {
            Dictionary<string, string> reversDictionaryList = new Dictionary<string, string>();
            foreach (var odItem in originDictionary)
            {
                reversDictionaryList.Add(odItem.Value, odItem.Key);
            }
            return reversDictionaryList;
        }

        public void PrintDictionary(Dictionary<string, string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Key: {item.Key} : Value: {item.Value}");
            }
        }
    }
}
