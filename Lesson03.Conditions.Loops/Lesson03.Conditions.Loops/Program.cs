using System;

namespace Lesson03.Conditions.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 6;

            if (a < b || true)
            {
                Console.WriteLine($"{a} is less than {b}");
            }
            else
            {
                Console.WriteLine($"{a} is less than {b}");
            }

            const int number = 20;
            string s = a > 15
                 ? $"{a} is more than {number}"
                 : $"{a} is more than {number}";

            int c = a < b
                ? a + b
                : a - b;

            Console.WriteLine(s);
            Console.WriteLine(c);

            switch (a)
            {
                case 1:
                    Console.WriteLine($"Today is Sunday");
                    break;
                case 2:
                    Console.WriteLine($"Today is Monday");
                    break;
                case 7:
                    Console.WriteLine($"Today is Tesday");
                    break;
                default:
                    Console.WriteLine("Today is smth");
                    break;
            }

            const int N = 10;
            int sum = 0;
            int i = 0;

            for (i = 0; i < N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum of {N} is {sum}");

            i = 0;
            sum = 0;

            while (i != N)
            {
                sum += i++;
            }

            Console.WriteLine($"Sum of {N} is {sum}");

            i = 0;
            sum = 0;

            do
            {
                sum += i++;
            } while (i < N);

            Console.WriteLine($"Sum of {N} is {sum}");

            i = 0;
            sum = 0;

            for (; i < N; i++)
            {
                sum += (i % 2 == 0)
                    ? i
                    : 0;
            }

            Console.WriteLine(sum);

            i = 0;
            sum = 0;

            for (; i < N; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                sum += i;
            }

            Console.WriteLine(sum);

            i = 0;
            sum = 0;

            while (true)
            {
                sum += i % 2 == 0
                     ? i++
                     : 0;
                if (++i >= N)
                {
                    break;
                }
            }

            Console.WriteLine(sum);

            string message = Console.ReadLine();

            if (int.TryParse(message, out int digit))
            {
                Console.WriteLine(digit);
            }
            else
            {
                Console.WriteLine("Input is incorrect");
            }

            //16 - 0001 0000
            Console.WriteLine(16 >> 100);


            int a1 = 0;
            int b1 = 0;
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter a: ");
            while (!int.TryParse(Console.ReadLine(), out a1))
            {
                Console.WriteLine("Try again");
            }
            Console.Write("Enter b: ");
            while (!int.TryParse(Console.ReadLine(), out b1))
            {
                Console.WriteLine("Try again");
            }
            Console.Write("Enter v: ");
            while (!int.TryParse(Console.ReadLine(), out v))
            {
                Console.WriteLine("Try again");
            }

            switch (v)
            {
                case 1:
                    Console.WriteLine(a1 + b1);
                    break;
                case 2:
                    Console.WriteLine(a1 + b1);
                    break;
                case 3:
                    Console.WriteLine(a1 + b1);
                    break;
                case 4:
                    Console.WriteLine(a1 + b1);
                    break;
                default:
                    break;
            }


            //--------------------------HOMEWORK--------------------------/

            Console.WriteLine("Input first nubmer: ");
            string x = Console.ReadLine();
            Console.WriteLine("Input second number: ");
            string y = Console.ReadLine();
            int summar = 0;

            int A = 0;
            int B = 0;

            bool result = int.TryParse(x, out A);
            bool result1 = int.TryParse(y, out B);
            bool correct = result1 & result;

            if (correct != true)
            {
                Console.WriteLine("Invalid input!");
            }

            else
            {

                if (A < B)
                {
                    while (A <= B)
                        sum += A++;
                }
                else
                {
                    while (A >= B)
                        sum += A--;
                }
                if (x == y)
                {
                    Console.WriteLine("\nX and Y equal: " + Math.Max(A, B));
                }

                Console.WriteLine("\nSummary is: " + summar);
            }
        }
    }
}
