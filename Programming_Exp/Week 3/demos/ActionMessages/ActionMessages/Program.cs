using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ActionMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> messageTarget;

            if (args.Length > 1)
            {
                messageTarget = ShowWindowsMessage;
            }
            else
            {
                messageTarget = Console.WriteLine;
                //messageTarget = new Action<string>(Console.WriteLine);
            }

            messageTarget("Invoking Action!");
            Console.Read();
        }

        private static void ShowWindowsMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
