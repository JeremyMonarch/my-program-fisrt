using System;

namespace Homework_6_7_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert array size: ");

            int ArraySize = int.Parse(Console.ReadLine());
            int[] array1 = new int[ArraySize];
            
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Your array: ");
            
            for(int i = 0; i < array1.Length;i++)
            {
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine("\nSorted by Bubble Sort: ");
            
            foreach (int item in BubbleSort(array1))
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nSorted by Selection: ");
            
            foreach (int item in SelectionSort(array1))
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nSorted by Insertion: ");

            foreach (int item in InsertionSort(array1))
            {
                Console.Write($"{item} ");
            }
            
            Console.ReadLine();
        }

        static int[] BubbleSort(int[] array1)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1.Length - 1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        int temp = array1[j + 1];
                        array1[j + 1] = array1[j];
                        array1[j] = temp;
                    }
                }
            }
            
            return array1;
        }

        static int[] SelectionSort(int[] array1)
        {
            int MinValue, tmp;
            for (int i = 0; i < array1.Length - 1; i++)
            {
               MinValue = i;
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[j] < array1[MinValue])
                    {
                        MinValue = j;
                    }
                }
                tmp = array1[MinValue];
                array1[MinValue] = array1[i];
                array1[i] = tmp;
            }
            return array1;
        }
        static int[] InsertionSort(int[] array1)
        {
            for (int i = 1; i < array1.Length; i++)
            {
                var temp = array1[i];
                var j = i;
                while ((j > 1) && (array1[j - 1] > temp))
                {
                    temp = array1[--j];
                    array1[j] = array1[j - 1];
                    array1[j - 1] = temp;
                }
            }
            return array1;
        }
    }
}
