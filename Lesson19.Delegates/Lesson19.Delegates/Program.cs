using System;
using System.Linq;

namespace Lesson19.Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var counter = new Counter();
            counter.Increment(10, delegate(int value, int NewValue)
                {
                    Console.WriteLine($"{value} changes it`s value to {NewValue}");
            });

            counter.Decrement(10, (old, @new) => Console.WriteLine($"{old} changed it`s value to {@new}"));

            counter.Increment(20, Callback);
            counter.Decrement(20, (value, newValue) => Callback(value, newValue));

            counter.OnValueChanged += Callback;
            counter.Increment(100);

            counter.OnValueChangedDelegate = Callback;

            counter.Decrement(100);

            int i = 50;
            var writer = new ConsoleWriter();
            counter.Increment(30, (value, newValue) =>
            {
                writer.Write(i.ToString());
            });

            var array = Enumerable.Range(0, 20).ToArray();
            
            var filtredArray = Where(array, x => x % 2 == 0);
            
            foreach (var item in filtredArray)
            {
                Console.Write($"{item} ");
            }
            foreach (var item in Where(array, x => x % 3 == 0))
            {
                Console.Write($"{item} ");
            }
            foreach (var item in Where(array, x => x % 4 == 0))
            {
                Console.Write($"{item} ");
            }
            foreach (var item in Where(array, x => x % 5 == 0))
            {
                Console.Write($"{item} ");
            }

        }


        //public static U[] Select<T, U>(T[] array, Func<T, U> func);
        //public static bool Any<T>(T[] array, Func<bool, T> func);
        //public static T FirstOrDefault<T>(T[] array, Func<U, T> func);


        public static T[] Where<T>(T[] array, Predicate<T> predicate)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(predicate(array[i]))
                {
                   count++;
                }
            }

            var newArray = new T[count];

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    newArray[j++] = array[i];
                }
            }

            return newArray;
        }

        public class ConsoleWriter
        {
            public void Write(string message)
            {
                Console.WriteLine(message);
            }
        }

        public static void Callback(int value, int newValue)
        {
            Console.WriteLine($"{value} changed it`s value to {newValue}");
        }

        public delegate void ChangedDelegate(int OldValue, int NewValue);

        public class Counter
        {
            public event ChangedDelegate OnValueChanged;

            public ChangedDelegate OnValueChangedDelegate;
            public void Increment(int i)
            {
                var old = i;
                var @new = ++i;

                OnValueChanged?.Invoke(old, @new);
            }

            public void Increment(int i, ChangedDelegate callback)
            {
                var old = i;
                var @new = ++i;

                callback(old, @new);
            }

            public void Decrement(int i, ChangedDelegate callback)
            {
                var old = i;
                var @new = --i;

                callback(old, @new);
            }

            public void Decrement(int i)
            {
                var old = i;
                var @new = --i;

                OnValueChangedDelegate(old, @new);
            }
        }
    }
}
