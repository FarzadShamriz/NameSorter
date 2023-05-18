using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Models
{
    /// <summary>
    /// This model implemented to use for creating the person objects
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Person Id added for the future - we may need to query based on id - Id can generate in another way.
        /// </summary>
        private int _personID { get; set; }

        /// <summary>
        /// This property contains the full text read in each line
        /// </summary>
        private string OriginalFullName { get; set; }

        /// <summary>
        /// This property contains the last name extracted from the full name
        /// </summary>
        private string _lastName { get; set; }

        /// <summary>
        /// This property contains the first name extracted from the full name
        /// </summary>
        private string _firstName { get; set; }


        /// <summary>
        /// Getter and setter for the first name
        /// </summary>
        public string FirstName { get => _firstName; set => _firstName = value; }
        /// <summary>
        /// Getter and setter for the last name
        /// </summary>
        public string LastName { get => _lastName; set => _lastName = value; }
        /// <summary>
        /// Getter and setter for the person ID
        /// </summary>
        public int PersonID { get => _personID; set => _personID = value; }

        /// <summary>
        /// Constructor implemented to set the private values in 
        /// creating an instance from this class
        /// </summary>
        /// <param name="personID">Id of the person</param>
        /// <param name="originalFullName">Raw full name</param>
        /// <param name="firstName">Extracted first name</param>
        /// <param name="lastName">Extracted last name</param>
        public Person(int personID, string originalFullName, string firstName, string lastName)
        {
            OriginalFullName = originalFullName;
            _personID = personID;
            _firstName = firstName;
            _lastName = lastName;
        }
    }
}
