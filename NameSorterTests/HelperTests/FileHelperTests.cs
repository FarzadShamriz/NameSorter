using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using NameSorter.Helpers;
using NameSorter.Models;

namespace NameSorterTests.HelperTests
{
    [TestClass]
    public class FileHelperTests
    {

        [TestInitialize]
        public void init()
        {
            //Prepare the requirements here
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

        #endregion

    }
}
