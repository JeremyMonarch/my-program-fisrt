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

            string[] content = File.ReadAllLines(FilePath);
          
            foreach (var item in content)
            {
                Console.WriteLine(item);
            }

            foreach ((string name, int number) item in Deserialize(content))
            {
                Console.WriteLine($"Name is {item.name}, nubmer is {item.number}");
            }

            var PhoneBook = Deserialize(content);

            var newRecord = (name: "Jacob", number: 12312);
            Add(ref PhoneBook, newRecord);
            Update(PhoneBook, newRecord, 3);
            Delete(ref PhoneBook, 0);
            
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
            content[index] = updatedItem;
        }

        private static string[] Serialize((string name, int number)[] content)
        {
            var strings = new string[content.Length];
           
            for (int i = 0; i < content.Length; i++)
            {
                strings[i] = $"{content[i].name};{content[i].number}";
            }
            return strings;
        }

        private static (string name, int number)[] Deserialize(string[] content)
        {
            var regexp = new Regex(@"^(\w+);(\d+)$");
            var book = new (string name, int number)[content.Length];

            for (int i = 0; i < content.Length; i++)
            {
                var item = content[i];
                var match = regexp.Match(item);

                if (match.Success)
                {
                    book[i].name = match.Groups[1].Value;
                    book[i].number = int.Parse(match.Groups[2].Value);
                }
            }    
            return book;
        }
    }
}
