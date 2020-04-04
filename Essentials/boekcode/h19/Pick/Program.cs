using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pick
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            string wanted = args[1];
            StreamReader inputStream = File.OpenText(fileName);
            string line = inputStream.ReadLine();
            while (line != null)
            {
                if (line.IndexOf(wanted) >= 0)
                {
                    Console.WriteLine(line);
                }
                line = inputStream.ReadLine();
            }
            inputStream.Close();
            //string wait = Console.ReadLine();
        }
    }
}
