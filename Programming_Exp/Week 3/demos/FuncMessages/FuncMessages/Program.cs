using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> logFunc;

            if (args[0] == "EventLog")
            {
                logFunc = LogToEventLog;
            }
            else
            {
                logFunc = LogToFile;
            }

            bool status = logFunc("Log Message");
            Console.Read();
        }

        private static bool LogToFile(string msg)
        {
            throw new NotImplementedException();
        }

        private static bool LogToEventLog(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
