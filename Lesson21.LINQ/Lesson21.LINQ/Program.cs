using System;
using System.Linq;

namespace Lesson21.LINQ
{
    internal class Program
    {
        public static void Main()
        {
            var array = Enumerable.Range(0, 20).ToArray();
            var newArray = array.Where(x => x % 2 == 0).ToArray();
            
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }

            foreach (var item in array.Select(x => x * 2))
            {
                Console.WriteLine(item);
            }

            foreach(var item in array.OwnSelect(x => x * 2))
            {
                Console.WriteLine(item);
            }

            var enumerable = from item in array
                             where item % 2 == 0
                             select item * 3;
            
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }


            array.Any(x => x == 100);
            array.All(x => x < 100);
            array.Take(3);

            foreach (var item in array.Append(40).Append(50).Append(60))
            {
                Console.WriteLine(item);
            }

            Enumerable.Repeat(10, 10);

            var balls = Enumerable.Range(0, 10).Select(x => new Ball()).ToArray();

            balls.Where(x => x.Color == Color.Green).Select(x => x.Color = Color.Blue).Take(2).ToArray();

        }
    }

    class Ball
    {
        public Color Color { get; set; }
    }

    enum Color
    {
        Green = 1,
        Blue = 2
    }
}
