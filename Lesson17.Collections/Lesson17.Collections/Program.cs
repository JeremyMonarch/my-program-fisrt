using System;

namespace Lesson17.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            foreach (var item in list.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list.Contains(1));

            var stringList = new LinkedList<string>
            {
               "sewfs",
               "asfawdaw222"
            };

            foreach (var item in stringList.GetAll())
            {
                Console.WriteLine(item);
            }

            var set = new Set<int>(100);
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(33);

            Console.WriteLine(set.Contains(1));
            Console.WriteLine(set.Contains(3));
            Console.WriteLine(set.Contains(33));
            Console.WriteLine(set.Contains(45));


        }
    }
}
