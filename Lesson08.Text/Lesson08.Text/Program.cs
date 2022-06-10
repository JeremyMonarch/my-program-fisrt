using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lesson08.Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FilePath = "PhoneBook.csv";

            string[] content = null;
            try
            {
                content = File.ReadAllLines(FilePath);
                
                foreach (var item in content)
                {
                    Console.WriteLine(item);
                }
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine($"Error: {exception.Message}, type: {exception.GetType()}");
                content = Array.Empty<string>();
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
          

            var PhoneBook = Deserialize(content);
            
            Console.WriteLine("------------------------------");
            SortBook(ref PhoneBook, 1);
            foreach ((string name, string surname, int number) item in PhoneBook)
            {
                Console.WriteLine($"Name is {item.name}, surname is {item.surname}, nubmer is {item.number}");
            }

            Console.WriteLine("------------------------------");
            Console.Write("Insert name/surname: ");
            string x = String.Empty;
            int result;
            try
            {
                x = Console.ReadLine();
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine($"{ exception.GetType()} Incorrect input");
            }
            finally
            {
                result = BinarySearch(PhoneBook, x, 1);
            }
           
            Console.WriteLine("------------------------------");
            if (result == -1)
            { 
                Console.WriteLine("Not found");
            }
            else 
            { 
                Console.WriteLine($"Your result: {PhoneBook[result]}"); 
            }
            Console.WriteLine("------------------------------");
            
            var serializedBook = Serialize(PhoneBook);

            foreach (var item in serializedBook)
            {
                Console.WriteLine(item);
            }

            File.WriteAllLines(FilePath, serializedBook);
        }

        private static void Add(ref (string name, int number)[] content, (string name, int number) newItem)
        {
            var newBook = new (string name, int number)[content.Length + 1];
            content.CopyTo(newBook, 0);
            newBook[content.Length] = newItem;
            content = newBook;
        }

        private static void Delete(ref (string name, int number)[] content, int index)
        {
            var newBook = new (string name, int number)[content.Length - 1];
            int j = 0;
            for (int i = 0; i < content.Length; i++)
            {
                if (i != index)
                {
                    newBook[j++] = content[i];
                }
            }
            content = newBook;
        }

        private static void Update((string name, int number)[] content, (string name, int number) updatedItem, int index)
        {
            try
            {
                content[index] = updatedItem;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }

        private static string[] Serialize((string name, string surname, int number)[] content)
        {
            var strings = new string[content.Length];
           
            for (int i = 0; i < content.Length; i++)
            {
                strings[i] = $"{content[i].name};{content[i].surname};{content[i].number}";
            }
            return strings;
        }

        private static (string name, string surname, int number)[] Deserialize(string[] content)
        {
            var regexp = new Regex(@"^(\w+);(\w+);(\d+)$");
            var book = new (string name, string surname, int number)[content.Length];

            for (int i = 0; i < content.Length; i++)
            {
                var item = content[i];
                var match = regexp.Match(item);
                // if (regexp.Match(content[i]).Success)
                if (match.Success)
                {
                    book[i].name = match.Groups[1].Value;
                    book[i].surname = match.Groups[2].Value;
                    book[i].number = int.Parse(match.Groups[3].Value);
                }
            }    
            return book;
        }

        //--------------------------------------HOMEWORK-------------------------------------------//

        private static void SortBook(ref (string name, string surname, int number)[] sortedbook, int FieldNo)
        {
            (string name, string surname, int number) temp;
            int idx = 0;
                for (int i = 1; i < sortedbook.Length; i++)
                {
                    for (int j = 0; j < sortedbook.Length - 1; j++)
                    {
                   
                    switch (FieldNo)
                    {
                        case 1:
                            idx = string.Compare(sortedbook[j].name, sortedbook[j + 1].name);
                            break;
                        case 2:
                            idx = string.Compare(sortedbook[j].surname, sortedbook[j + 1].surname);
                            break;
                    }
                        if (idx > 0)
                        {
                        temp = sortedbook[j];
                        sortedbook[j] = sortedbook[j + 1];
                        sortedbook[j + 1] = temp;
                        }
                    }
                }
        }
        static int BinarySearch((string name, string surname, int number)[] book, string x, int FieldNo)
        {
            int idx = 0;
            int l = 0, r = book.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;
                switch (FieldNo)
                {
                    case 1:
                        idx = string.Compare(book[m].name, x);
                        break;
                    case 2:
                        idx = string.Compare(book[m].surname, x);
                        break;
                }

                if (idx == 0)
                {
                    return m;
                }

                if (idx < 0)
                    l = m + 1;
                else
                    r = m - 1;
            }
            return -1;
        }
    }
}
