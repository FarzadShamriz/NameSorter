using NameSorter.Helpers;
using NameSorter.Models;

namespace NameSorterTests
{
    [TestClass]
    public class NameSorterTests
    {
        [TestMethod]
        public void SortTest1()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person(1, "Janet Parsons", "Janet", "Parsons"));
            persons.Add(new Person(2, "Adonis Julius Archer", "Adonis Julius", "Archer"));
            persons.Add(new Person(3, "Marin Alvarez", "Marin", "Alvarez"));
            persons.Add(new Person(4, "Marin Alvarezz", "Marin", "Alvarezz"));
            
            var sortedPersons = PersonHelper.SortPersonListByLastNameThenFirstName(persons);
            Assert.AreEqual(3, sortedPersons.First().PersonID);
        }
    }
}