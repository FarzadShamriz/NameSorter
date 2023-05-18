using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using NameSorter.Helpers;
using NameSorter.Models;

namespace NameSorterTests.HelperTests
{
    [TestClass]
    public class FileHelperTests
    {
        private List<Person> personsTestList = new List<Person>();

        [TestInitialize]
        public void init()
        {
            //Prepare the requirements here
            personsTestList.Add(new Person(1, "Janet Parsons", "Janet", "Parsons"));
            personsTestList.Add(new Person(2, "Adonis Julius Archer", "Adonis Julius", "Archer"));
            personsTestList.Add(new Person(3, "Marin Alvarez", "Marin", "Alvarez"));
            personsTestList.Add(new Person(4, "Marin Alvarezz", "Marin", "Alvarezz"));
            personsTestList.Add(new Person(5, "ZMarin Alvarezz", "Marin", "Alvarezz"));
            personsTestList.Add(new Person(6, "", "", ""));
            personsTestList.Add(new Person(7, "Marin zlvarezz", "Marin", "Alvarezz"));
        }

        #region ValidateFileByPath
        [TestMethod]
        public void ValidateFileByEmptyPath()
        {
            Assert.IsFalse(FileHelper.ValidateFileByPath(string.Empty).FileIsValid);
        }

        [TestMethod]
        public void ValidateFileByWrongPath()
        {
            Assert.IsFalse(FileHelper.ValidateFileByPath("./test/Not exists/test/test.txt").FileIsValid);
        }

        [TestMethod]
        public void ValidateFileByWringFileExt()
        {
            Assert.IsFalse(FileHelper.ValidateFileByPath("./name-sorter.dll").FileIsValid);
        }

        [TestMethod]
        public void ValidateFileByCorrectPath()
        {
            Assert.IsTrue(FileHelper.ValidateFileByPath("./input.txt").FileIsValid);
        }
        #endregion

        #region SerializeFileToPersonList
        [TestMethod]
        public void SerializeTheFileToPersonList()
        {
            Assert.AreEqual(13, FileHelper.SerializeFileToPersonList("./input.txt").Count());
        }
        #endregion

        #region WritePersonListInFile
        [TestMethod]
        public void WriteListInAFileTest()
        {
            Assert.IsTrue(FileHelper.WritePersonListInFile(personsTestList));
        }
        #endregion

    }
}
