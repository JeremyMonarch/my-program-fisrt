using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

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

            HomeWork();
        }

        private void Print(string placeholder, string name)
        {
            Console.WriteLine(string.Format(placeholder, name));
            Console.WriteLine($"Hello, {name}");
        }

        //----------------------------------------------------HOMEWORK------------------------------------------//

        static void HomeWork()
        {
            PrintInsertStrings();
            string st = Console.ReadLine();
            string nd = Console.ReadLine();

            Console.WriteLine(Cmpr(st, nd));

            int dgt = 0;
            int str = 0;
            int sym = 0;

            string exp = "Hello, buddy12345!#%%$#^&!";
            Console.WriteLine(Analyze(exp, out dgt, out str, out sym));
            Console.WriteLine($"Letters = {str}, Digits = {dgt}, Symbols = {sym}");

            PrintStrongsToSort();
            Console.WriteLine(Sort(Console.ReadLine()));

            Duplicate(Console.ReadLine());
        }

        static public bool Cmpr(string st, string nd)
        {
            if (st.Length != nd.Length)
            {
                return false;
            }

            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] != nd[i])
                {
                    return false;
                }
            }
            return true;
        }

        static public string Analyze(string exp, out int dgt, out int str, out int sym)
        {
            dgt = 0;
            str = 0;
            sym = 0;
            foreach (char c in exp)
            {
                if (char.IsLetter(c))
                    str++;
                else if (char.IsDigit(c))
                    dgt++;
                else
                    sym++;
            }
            return exp;
        }

        static public char[] Sort(string x)
        {
            char[] sorted = x.ToCharArray();
            char temp;

            for (int i = 1; i < sorted.Length; i++)
            {
                for (int j = 0; j < sorted.Length - 1; j++)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }
            return sorted;
        }

        static public void Duplicate(string str)
        {
            Dictionary<char, int> count = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (count.ContainsKey(str[i]))
                    count[str[i]]++;
                else
                    count[str[i]] = 1;
            }
            foreach (var it in count.OrderBy(key => key.Value))
            {
                if (it.Value > 1)
                    Console.WriteLine(it.Key + ", count = " +
                                      it.Value);
            }
        }

        private static void PrintInsertStrings()
        {
            Console.WriteLine("Insert 1fs and 2nd strings: ");
        }
        private static void PrintStrongsToSort()
        {
            Console.WriteLine("Insert string: ");
        }
    }
}
