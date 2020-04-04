using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDelegate
{
    class Program
    {
        delegate int AddDelegate(int a, int b);

        delegate bool LogDelegate();

        static void Main(string[] args)
        {
            //AddDelegate ad = (a, b) => a + b;
            //int result = ad(1, 1); // result = 2

            LogDelegate ld = () =>
            {
                UpdateDatabase();
                WriteToEventLog();
                return true;
            };

            bool status = ld();
        }

        static void UpdateDatabase()
        { 
            // Dummy method
        }

        static void WriteToEventLog()
        {
            // Dummy method
        }
    }
}
