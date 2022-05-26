using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.IntoToOop
{
    public class Person
    {
        //private const int Divisor = 2;
        private static int Divisor = 2;
        private int _age;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int PropAge
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value / Divisor;
            }
        }

        public int GetAge()
        {
            return this._age;
        }

        public void SetAge(int age)
        {
            this._age = age;
        }

        public static Person Create(string firstName, string lastName, int age)
        {
            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            person._age = age;

            return person;
        }

        public string FullName => $"{this.FirstName} {this.LastName}";

        public Person()
        {

        }
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._age = age;
        }
        public string FullInfo => $"{this.FullName}, {this._age} years old";
    }
}
