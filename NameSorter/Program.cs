using NameSorter.Helpers;
using NameSorter.Models;



IConsoleLogger consoleLogger = new ConsoleLogger();
try
{
    //Check if args are entered correctly
    if (Environment.GetCommandLineArgs().Length > 1)
    {
        string inputFilePath = Environment.GetCommandLineArgs()[1];
        var fileValidationResult = FileHelper.ValidateFileByPath(inputFilePath);

        if (fileValidationResult.FileIsValid)
        {
            
            consoleLogger.log(fileValidationResult.ValidatorMessage, IConsoleLogger.MessageType.INFO);



            List<Person> serializedPersonList = FileHelper.SerializeFileToPersonList(inputFilePath);

            if (serializedPersonList.Count < 1)
            {
                consoleLogger.log("File is empty.", IConsoleLogger.MessageType.ERROR);
            }
            else
            {
                List<Person> sortedPersonList = PersonHelper.SortPersonListByLastNameThenFirstName(serializedPersonList);
                FileHelper.WritePersonListInFile(sortedPersonList);

                Console.WriteLine("=============== Sorted Full Names =================", ConsoleColor.Green);
                foreach (Person person in sortedPersonList)
                {
                    var fullName = $"{person.FirstName} {person.LastName}";
                    if (!string.IsNullOrEmpty(fullName.Trim()))
                    {
                        consoleLogger.log(fullName, IConsoleLogger.MessageType.INFO);
                    }

                }
                Console.WriteLine("===================================================", ConsoleColor.Green);
            }
        }
        else
        {
            consoleLogger.log("Wrong file path.", IConsoleLogger.MessageType.WARNING);
        }
    }
    else
    {
        consoleLogger.log("Wrong command.", IConsoleLogger.MessageType.WARNING);
    }
}
catch (Exception e)
{
    consoleLogger.log(e.Message, IConsoleLogger.MessageType.ERROR);
}


