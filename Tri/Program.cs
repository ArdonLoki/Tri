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

            Console.WriteLine($"{string.Join(", ", myNum)}");

            BubbleSort();

            Console.WriteLine($"{string.Join(", ", myNum)}");
        }
        static void BubbleSort()
        {
            while (isSorted() == false) {
                for (int i = 0; i < myNum.Length - 1; i++)
                {
                    if (myNum[i] > myNum[i + 1])
                    {
                        int temp = myNum[i];
                        myNum[i] = myNum[i + 1];
                        myNum[i + 1] = temp;
                    }
                }
            }
        }
        static bool isSorted() 
        {
            for (int i = 0; i < myNum.Length - 1; i++) 
            {
                if (myNum[i] > myNum[i+1])
                {
                    return false;
                }
            }
            return true;
        }

        static void InsertionSort(int[] array)
        {
            
        }
    }
}