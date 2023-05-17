using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Models
{
    public class Person
    {
        private int _personID { get; set; }
        private string OriginalFullName { get; set; }
        private string _lastName { get; set; }
        private string _firstName { get; set; }

        public Person(int personID, string originalFullName, string firstName, string lastName)
        {
            OriginalFullName = originalFullName;
            _personID = personID;
            _firstName = firstName;
            _lastName = lastName;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int PersonID { get => _personID; set => _personID = value; }
    }
}
