using static NameSorter.Helpers.IConsoleLogger;

namespace NameSorter.Helpers
{
    internal class ConsoleLogger : IConsoleLogger
    {
        public void log(string message, MessageType msgType)
        {
            switch (msgType)
            {
                case MessageType.ERROR:
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("================================", ConsoleColor.Red);
                    Console.WriteLine(message, ConsoleColor.Red);
                    Console.WriteLine("================================", ConsoleColor.Red);
                    break;
                case MessageType.INFO:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("================================", ConsoleColor.Blue);
                    Console.WriteLine(message, ConsoleColor.Blue);
                    Console.WriteLine("================================", ConsoleColor.Blue);
                    break;
                case MessageType.WARNING:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("================================", ConsoleColor.Yellow);
                    Console.WriteLine(message, ConsoleColor.Yellow);
                    Console.WriteLine("================================", ConsoleColor.Yellow);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("================================", ConsoleColor.White);
                    Console.WriteLine(message, ConsoleColor.White);
                    Console.WriteLine("================================", ConsoleColor.White);
                    break;

            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void logError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void logInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void logWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
