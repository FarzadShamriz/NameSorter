using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter.Helpers
{
    internal interface IConsoleLogger
    {
        enum MessageType
        {
            ERROR = 0,
            WARNING = 1,
            INFO = 2
        }

        public void log(string message, MessageType msgType);

        public void logInfo(string message);
        public void logWarning(string message);
        public void logError(string message);

    }
}
