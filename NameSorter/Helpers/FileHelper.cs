using NameSorter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Helpers
{
    public class FileHelper
    {
        private static readonly string _fileNotFoundMsg = "File is not exist in the entered path.";
        private static readonly string _fileFoundMsg = "File is exist.";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static FileValidatorResult ValidateFileByPath(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new FileValidatorResult { FileIsValid = false, ValidatorMessage = _fileNotFoundMsg };
            }
            return new FileValidatorResult { FileIsValid = true, ValidatorMessage = _fileFoundMsg }; ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static List<Person> SerializeFileToPersonList(string filePath)
        {
            var personList = new List<Person>();
            var extractedLinesFromFile = File.ReadAllLines(filePath);
            var PersonCounter = 0;
            if (extractedLinesFromFile.Length > 0)
            {
                foreach (var personItem in extractedLinesFromFile.ToList())
                {
                    if (personItem.Trim().Length > 0)
                    {
                        var lastName = personItem.Trim().Split(' ').Last();
                        var firstName = personItem.Replace(lastName, "").Trim();
                        var newPerson = new Person(PersonCounter, personItem, firstName, lastName);
                        personList.Add(newPerson);
                        PersonCounter++;
                    }
                }
            }
            return personList;
        }
    }
}
