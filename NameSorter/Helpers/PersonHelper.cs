using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Helpers
{
    public class PersonHelper
    {

        public static List<Person> SortPersonListByLastNameThenFirstName(List<Person> persons)
        {
            return persons.OrderBy(person => person.LastName).ThenBy(person => person.FirstName).ToList();
        }

    }
}
