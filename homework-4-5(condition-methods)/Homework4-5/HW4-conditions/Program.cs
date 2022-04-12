using System;

namespace HW4_conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first nubmer: ");
            string x = Console.ReadLine();
            Console.WriteLine("Input second number: ");
            string y = Console.ReadLine();
            int sum = 0;

            int a = 0;
            int b = 0;

            bool result = int.TryParse(x, out a);
            bool result1 = int.TryParse(y, out b);
            bool correct = result1 & result;

            if (correct != true)
            {
                Console.WriteLine("Invalid input!");
            }
            
            else
            {

                if (a < b)
                {
                    while (a <= b)
                        sum += a++;
                }
                else
                {
                    while (a >= b)
                        sum += a--;
                }
                if (x == y)
                {
                    Console.WriteLine("\nX and Y equal: " + Math.Max(a, b));
                }

                Console.WriteLine("\nSummary is: " + sum);
            }
        }

    }
}
