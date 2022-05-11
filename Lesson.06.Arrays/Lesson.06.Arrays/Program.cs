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

            HomeWork();
            
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


        //-------------------------------------------------------HOMEWORK---------------------------------------//

        static void HomeWork()
        {

            Console.Write("Insert array size: ");

            int ArraySize = int.Parse(Console.ReadLine());
            int[] array1 = new int[ArraySize];
            int[] array2 = RandomArray(10);
            int[] array3 = RandomArray(10);

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Your array: ");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine("\nSorted by Bubble Sort: ");

            foreach (int item in BubbleSort(array1))
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nSorted by Selection: ");

            foreach (int item in SelectionSort(array2))
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nSorted by Insertion: ");

            foreach (int item in InsertionSort(array3))
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();
        }

        static int[] RandomArray(int Length)
        {
            Random random = new Random();
            var array = new int[Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            return array;
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

        static int[] SelectionSort(int[] array2)
        {
            int MinValue, tmp;
            for (int i = 0; i < array2.Length - 1; i++)
            {
                MinValue = i;
                for (int j = i + 1; j < array2.Length; j++)
                {
                    if (array2[j] < array2[MinValue])
                    {
                        MinValue = j;
                    }
                }
                tmp = array2[MinValue];
                array2[MinValue] = array2[i];
                array2[i] = tmp;
            }
            return array2;
        }
        static int[] InsertionSort(int[] array3)
        {
            for (int i = 0; i < array3.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array3[j - 1] > array3[j])
                    {
                        int temp = array3[j - 1];
                        array3[j - 1] = array3[j];
                        array3[j] = temp;
                    }
                }
            }
            return array3;
        }
    }
}
