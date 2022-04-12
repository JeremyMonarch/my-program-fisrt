using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
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

            static bool TrySumIfOdd (int a, int b, out int sum)
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
