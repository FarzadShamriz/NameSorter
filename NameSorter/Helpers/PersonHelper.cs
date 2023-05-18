using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Helpers
{
    /// <summary>
    /// This class is responsible for all the person and person list process
    /// </summary>
    public class PersonHelper
    {
        /// <summary>
        /// This method is sorting the person list based on first name then last name
        /// Validations checked before catching this step
        /// </summary>
        /// <param name="personList">List of person objects to sort</param>
        /// <returns>Return the sorted list of the persons</returns>
        public static List<Person> SortPersonListByLastNameThenFirstName(List<Person> personList)
        {
            return personList.OrderBy(person => person.LastName).ThenBy(person => person.FirstName).ToList();
        }

    }
}
