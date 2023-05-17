using NameSorter.Helpers;
using NameSorter.Models;


//Check arg0
string inputFilePath = Environment.GetCommandLineArgs()[0];
var fileValidationResult = FileHelper.ValidateFileByPath(inputFilePath);

if (fileValidationResult.FileIsValid)
{
    Console.WriteLine("================================", ConsoleColor.Green);
    Console.WriteLine(fileValidationResult.ValidatorMessage, ConsoleColor.Green);
    Console.WriteLine("================================", ConsoleColor.Green);

    List<Person> serializedPersonList = FileHelper.SerializeFileToPersonList(inputFilePath);

    if (serializedPersonList.Count < 1)
    {
        Console.WriteLine("================================", ConsoleColor.Red);
        Console.WriteLine("File is empty.", ConsoleColor.Red);
        Console.WriteLine("================================", ConsoleColor.Red);
    }
    else
    {
        List<Person> sortedList = PersonHelper.SortPersonListByLastNameThenFirstName(serializedPersonList);

    }


}
