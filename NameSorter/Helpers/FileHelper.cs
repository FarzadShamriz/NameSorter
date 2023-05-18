using NameSorter.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Helpers
{
    /// <summary>
    /// This class contains the helper methods related to the file
    /// </summary>
    public class FileHelper
    {
        private static readonly string _fileNotFoundMsg = "File is not exist in the entered path.";
        private static readonly string _fileFoundMsg = "File is exist.";
        private static readonly string _filePathEmptyMsg = "Enter the file name.";
        private static readonly string _fileExtErrorMsg = "Enter the path of the text file.";
        private static readonly string _destFilePath = "sorted-names-list.txt";

        /// <summary>
        ///  This method is validating the file path entered by the user 
        ///  and returns an object that contains isValid flag as boolean and a message for the UI purposes
        /// </summary>
        /// <param name="filePath">String input parameter to validate the file</param>
        /// <returns>Returns an object that contains isValid flag as boolean and a message for the UI purposes</returns>
        public static FileValidatorResult ValidateFileByPath(string filePath)
        {

            if (string.IsNullOrEmpty(filePath.Replace(" ", "")))
            {
                return new FileValidatorResult { FileIsValid = false, ValidatorMessage = _filePathEmptyMsg };
            }
            else if (!Path.GetExtension(filePath).ToLower().Equals(".txt"))
            {
                return new FileValidatorResult { FileIsValid = false, ValidatorMessage = _fileExtErrorMsg };
            }
            else if (!File.Exists(filePath))
            {
                return new FileValidatorResult { FileIsValid = false, ValidatorMessage = _fileNotFoundMsg };

            }

            return new FileValidatorResult { FileIsValid = true, ValidatorMessage = _fileFoundMsg }; ;
        }

        /// <summary>
        /// This method is responsible to read the file line by line 
        /// from the path entered as an input,
        /// and create a person object based on the data read from the file.
        /// </summary>
        /// <param name="filePath">String input parameter to read the file</param>
        /// <returns>Returns a list of person objects</returns>
        public static List<Person> SerializeFileToPersonList(string filePath)
        {
            var personList = new List<Person>();
            var extractedLinesFromFile = File.ReadAllLines(filePath);
            var PersonCounter = 0;
            if (extractedLinesFromFile.Length > 0)
            {
                foreach (var personItem in extractedLinesFromFile.ToList())
                {
                    if (personItem.Trim().Length > 0 && personItem.Trim().Split(' ').Count() <= 4)
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

        /// <summary>
        /// This class is responsible to write the list of person in a file.
        /// It opens a file and take each person object to concatinate the 
        /// first name and last name to write it in a line.
        /// </summary>
        /// <param name="personList">List of person objects to write one by one in a file</param>
        /// <returns>Return true or false based on the process.</returns>
        public static bool WritePersonListInFile(List<Person> personList)
        {
            TextWriter sortedFile = new StreamWriter(_destFilePath);
            try
            {
                foreach (Person person in personList)
                {
                    var fullName = $"{person.FirstName} {person.LastName}";
                    if (!string.IsNullOrEmpty(fullName.Trim()))
                    {
                        sortedFile.WriteLine(fullName);
                    }
                    
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                sortedFile.Close();
            }
            return true;
        }
    }
}
