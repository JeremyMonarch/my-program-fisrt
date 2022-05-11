using System;
using System.Text;

namespace Lesson._07.Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Mykyta";
            string hisName = "Serhii";
            string placeholder = "Hello, {0} and {1}";

            Console.WriteLine("Hello, " + name);
            Console.WriteLine($"Hello, {name}, {hisName}");
            Console.WriteLine(string.Format("Hello, {0}, {1}", name, hisName));
            Console.WriteLine(string.Format(placeholder, name, hisName));

            var hello = $"Hello, {name}, {hisName}";
            char symbol = hello[5];
            Console.WriteLine(symbol);

            for (int i = 0; i < hello.Length; i++)
            {
                Console.Write(hello[i]);
            }

            Console.WriteLine();

            Console.WriteLine(char.IsDigit(symbol));
            Console.WriteLine(char.IsLetter(symbol));
            Console.WriteLine(char.IsLower(symbol));
            Console.WriteLine(char.IsUpper('a'));
            Console.WriteLine(char.IsPunctuation(symbol));

            Console.WriteLine(hello.Contains('H'));
            Console.WriteLine(hello.Contains('s', StringComparison.InvariantCultureIgnoreCase));
            
            Console.WriteLine(hello.Insert(7, "Alex "));
            Console.WriteLine(hello.Replace(name, hisName));
            Console.WriteLine(hello.Remove(7));
            Console.WriteLine(hello.Remove(7, 2));
            Console.WriteLine(hello.ToLowerInvariant());
            Console.WriteLine(hello.ToUpperInvariant());

            Console.WriteLine($"   {name}    ".Trim());
            
            foreach (var item in hello.Split('i', StringSplitOptions.RemoveEmptyEntries))
                {
                    Console.WriteLine(item.Trim());
                }

            Console.WriteLine(string.Compare("pbc", "abc"));
            Console.WriteLine(string.Compare("adc", "abc"));
            Console.WriteLine(string.Compare("abd", "abc"));
            Console.WriteLine("pbc" == "abc");
            Console.WriteLine(string.Compare("pbc", "Abc", StringComparison.InvariantCultureIgnoreCase));

            var emptyString = string.Empty;
            const int N = 1000;

            for (int i = 0; i < N; i++)
            {
                emptyString += $"{i}, ";
            }

            var stringbuilder = new StringBuilder();
            
            for (int j = 0; j < N; j++)
            {
                stringbuilder.AppendFormat($"{0}", j);
            }

            Console.WriteLine(stringbuilder.ToString());
            Console.WriteLine(emptyString);


        }

        private void Print(string placeholder, string name)
        {
            Console.WriteLine(string.Format(placeholder, name));
            Console.WriteLine($"Hello, {name}");
        }
    }
}
