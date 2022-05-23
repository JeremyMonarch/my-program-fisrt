using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.IntoToOop
{
    public class PhoneBookRecord
    {
        public Person person;
        public int number;

        public PhoneBookRecord(Person person, int number)
        {
            this.person = person;
            this.number = number;
        }

        public string FullInfo()
        {
            return $"{this.person.FullInfo()} with phone number {this.number}";
        }
    }
}
