using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Models
{
    /// <summary>
    /// This model created to use for the result that methods return after validating the file path
    /// </summary>
    public class FileValidatorResult
    {
        /// <summary>
        /// If file is valid set true; else false
        /// </summary>
        public bool FileIsValid { get; set; }

        /// <summary>
        /// Add a message based n the result to print in the console
        /// </summary>
        public string ValidatorMessage { get; set; }
    }
}
