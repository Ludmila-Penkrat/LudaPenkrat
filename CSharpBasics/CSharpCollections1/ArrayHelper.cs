using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CSharpCollections1
{
    public class ArrayHelper
    {
        Random random = new Random();
        public int GetArraySize()
        {
            int arraySize = random.Next(2, 10);
            return arraySize;
        }
        public int[] GetIntRandomArray(int arraySize)
        {
            int[] array = new int[arraySize];   
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }

        public double[] GetDoubleRandomArray(int arraySize)
        {
            double[] array = new double[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            return array;
        }

        public int[] GetEvenArrayFromRandomArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 == 0 && array[i] != 0)
                {
                    count++;
                }
            }
            int[] evenArray = new int[count];
            for (int i = 0, j=0; i < array.Length; i++)
            {
                if (array[i]%2 == 0 && array[i] != 0)
                {
                    evenArray[j] = array[i];
                    j++;
                }
            }
            return evenArray;
        }

        public int[] GetOddArrayFromRandomArray(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 != 0 && array[i] != 0)
                {
                    count++;
                } 
            }
            int[] oddArray = new int[count];
            for (int i = 0, j=0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0 && array[i] != 0)
                {
                    oddArray[j] = array[i];
                    j++;
                }
            }
            return oddArray;
        }

        public void PrintIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintDoubleArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public double FindMinValueInArray(double[] array)
        {
            double min = double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public double FindMaxValueInArray(double[] array)
        {
            double max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
   
    }
}
