using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chef.Models
{
    public class Person
    {
        public Person(DateTime birthDate, string firstName, string lastName)
        {
            BirthDate = birthDate;
            FirstName = firstName;
            LastName = lastName;
        }

        public DateTime BirthDate { get; }
        public string FirstName { get; }
        public string LastName { get; }
    }
}
