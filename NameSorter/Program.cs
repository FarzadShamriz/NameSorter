using NameSorter.Helpers;
using NameSorter.Models;



try
{
    if (Environment.GetCommandLineArgs().Length > 1)
    {
        string inputFilePath = Environment.GetCommandLineArgs()[1];
        var fileValidationResult = FileHelper.ValidateFileByPath(inputFilePath);
        Console.WriteLine(inputFilePath);

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
                List<Person> sortedPersonList = PersonHelper.SortPersonListByLastNameThenFirstName(serializedPersonList);
                FileHelper.WritePersonListInFile(sortedPersonList);
            }


        }
    }
    else
    {
        Console.WriteLine("================================", ConsoleColor.Red);
        Console.WriteLine("Wrong command.", ConsoleColor.Red);
        Console.WriteLine("================================", ConsoleColor.Red);
    }
}
catch (Exception e)
{
    Console.WriteLine(e.ToString());
}


