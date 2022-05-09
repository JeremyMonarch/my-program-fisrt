using System;

namespace Lesson._06.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int[] arr2 = new int[] {1, 2, 3, 4, 5 };
            int[] arr3 = { 1, 2, 3, 4, 5 };

            arr2[0] = 1;
            arr2[1] = 2;
            arr2[2] = 3;

            Print(arr);

            int i = 0;
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            Print(arr);
            
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 2;
            }
            
            Print(arr);

            var randomArray = GetArray(10);
            
            Print(randomArray);
            MultipleBy(randomArray, 2);
            Print(randomArray);

            var arr4 = Copy(randomArray);
            
            MultipleBy(arr4, 10);
            Print(arr4);

            Print(randomArray);
            
        }

        private static void Sort(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < minIndex)
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }

        private static int[] Copy(int[] arr)
        {
            int [] arr4 = new int [arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                arr4[i] = arr[i];
            }
            return arr4;
        }

        private static void MultipleBy(int[] array, int multiplier)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= multiplier;
            }
        }

        private static int[] GetArray(int legth)
        {
            Random random = new Random();
            var arr = new int [legth];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }

            return arr;
        }

        private static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} \t");
            }

            Console.WriteLine();
        }
    }
}
