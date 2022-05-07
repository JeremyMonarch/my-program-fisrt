using System;
using System.Linq;

namespace Lesson04.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Sum(10, 20);
            Console.WriteLine(sum);
            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20, true));
            Console.WriteLine(Sum(10, 20, false));
            Console.WriteLine(IsOdd(11));
            Console.WriteLine(SumNumbers(9, 10));
            Console.WriteLine(SumNumbers(11, 10));
            
            int i = 10;
            Increment(ref i);
            Increment(ref i);

            if (TryDivide(100, 10, out int result))
            {
                Console.WriteLine(result);
            }
            if (!TryDivide(11, 10, out result))
            {
                Console.WriteLine(result);
            }

            Concat("10", "20");
            Concat("10", "20", "30");
            Concat("10", "20", "30", "40");
            Concat("10", "20", "30", "40", "50");

            Console.WriteLine(Factorial(5));

            Master();
        }

        static int FactorialRecursive(int value)
        {
            if (value == 1) return value;
            Console.WriteLine($"{nameof(value)} -> {value}");
            return value *= FactorialRecursive(value - 1);
        }

        static int Factorial(int value)
        {
            int result = 1;
            for (int i = value; i > 0; i--)
            {
                result *= i;
            }
            
            return result;
        }

        static void Concat(params string[] strings)
        {
            Console.WriteLine(strings.Length);
        }

        static void Concat(string str1, string str2)
        {
            Console.WriteLine($"{str1} {str2}");
        }

        static void Concat(string str1, string str2, string str3)
        {
            Console.WriteLine($"{str1} {str2} {str3}");
        }

        static bool TryDivide(int a, int b, out int result)
        {
            result = a / b;
            return a % b == 0;
        }

        static void Increment(ref int i)
        {
            i++;
        }
        static bool IsOdd(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            
                return false;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, bool r = true)
        {
            if (r)
            {
                return a + b;
            }
            else
            {
                return a - b;
            }
        }

        static int SumNumbers(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }

            return sum;
        }

        //------------------------------HOMEWORK---------------------------------//

        static void Master()
        {
            Console.Write("Input first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Input string: ");
            string x = Console.ReadLine();

            MaxMinValue(54, 76);
            MaxMinValue(3, 43, 23);
            MaxMinValue(4.3, 9.23, 1.11, 13.32);

            Repeat(x);

            if (TrySumIfOdd(a, b, out int sum))
            {
                Console.WriteLine("\nParity \nSum is: " + sum);
            }

            else
            {
                Console.WriteLine("\nNot Parity \nSum is: " + sum);
            }

        }
        static void MaxMinValue(int x, int y)
        {
            Console.WriteLine("Max value is: " + Math.Max(x, y));
            Console.WriteLine("Min value is: " + Math.Min(x, y));
        }

        static void MaxMinValue(int x, int y, int z)
        {
            Console.WriteLine("\nMax value is: " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Min value is: " + Math.Min(x, Math.Min(y, z)));
        }

        static void MaxMinValue(double x, double y, double z, double w)
        {
            Console.WriteLine("\nMax value is: " + Math.Max(x, Math.Max(y, Math.Max(z, w))));
            Console.WriteLine("Min value is: " + Math.Min(x, Math.Min(y, Math.Min(z, w))));
        }

        static bool TrySumIfOdd(int a, int b, out int sum)
        {
            sum = a + b;
            return sum % 2 == 0;
        }

        static void Repeat(string x)
        {
            x = String.Concat(Enumerable.Repeat(x, 3));
            Console.WriteLine("Your triple string: " + x);
        }
    }
}
