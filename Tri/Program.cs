using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static public int[] myNum = { 10, 5, 3, 12, -1 };
        static void Main(string[] args)
        {
            Console.WriteLine();

            //Array.ForEach(myNum, Console.WriteLine);
            Console.WriteLine($"{string.Join(", ", myNum)}");

            //BubbleSort(myNum);

        }
        static void BubbleSort(int[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
        }
        static void InsertionSort(int[] array)
        {
            
        }
    }
}