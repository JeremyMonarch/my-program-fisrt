using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.GetByIndex(i));
            }

            var array = Enumerable.Range(0, 10).ToArray();
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }

            var index = 2;
            Console.WriteLine($"{index} itm of list is {list.GetByIndex(index)}");

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
