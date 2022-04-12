using System;

namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tHi! Wellcome to my homework!");

            {
                Console.WriteLine("\nInsert x : ");

                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insert y : ");

                int y = Convert.ToInt32(Console.ReadLine());

                int result = -6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15;

                double result2 = Math.Abs(x) * Math.Sin(x);

                double result3 = 2 * Math.PI * x;

                double result4 = Math.Max(x, y);

                Console.WriteLine("First result is: " + result);

                Console.WriteLine("Second result is: " + result2);

                Console.WriteLine("Thrird result is: " + result3);

                Console.WriteLine("Fourth result is: " + result4);

            }

        }
    }
}
