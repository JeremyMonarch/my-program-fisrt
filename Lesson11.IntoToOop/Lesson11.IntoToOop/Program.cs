using System;

namespace Lesson11.IntoToOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Mykyta";
            person.LastName = "Zakh";
            person.PropAge = 30;
            
            
            person.SetAge(12);

            var anotherPerson = new Person("Andrii", "Demchuk", 40);
            var thirdPerson = Person.Create("Lev", "Tolstoy", 24);

            var fourthPerson = new Person
            {
                FirstName = "Nick",
                LastName = "Someone",
            };
            
            fourthPerson.SetAge(30);

            Print(anotherPerson);
            Print(person);
            Print(thirdPerson);
            Print(fourthPerson);

            var records = new PhoneBookRecord[]
            {
                new PhoneBookRecord(person, 123),
                new PhoneBookRecord(anotherPerson, 321),
                new PhoneBookRecord(thirdPerson, 456),
                new PhoneBookRecord(fourthPerson, 987),
            };
            var phoneBook = new PhoneBook(records);
            foreach (var item in phoneBook.Records)
            {
                Console.WriteLine(item.FullInfo);
            }
        }

        private static void Print(Person person)
        {
            Console.WriteLine($"{person.FullInfo}");
        }
    }
}
