using NameSorter.Helpers;
using NameSorter.Models;

namespace NameSorterTests.HelperTests
{
    [TestClass]
    public class FileHelperTests
    {
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
        public void ValidateFileByCorrectPath()
        {
            Assert.IsTrue(FileHelper.ValidateFileByPath("./input.txt").FileIsValid);
        }
    }
}
