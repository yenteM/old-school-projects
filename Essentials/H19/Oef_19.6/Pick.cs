using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_19._6
{
    public class Pick
    {
        static void Main(string[] args)
        {
            string fileName = args[0];
            string wanted = args[1];
            StreamReader inputstream = File.OpenText(fileName);
            string line = inputstream.ReadLine();
            while (line != null)
            {
                if (line.IndexOf(wanted) >= 0)
                {
                    Console.WriteLine(line);
                }
                line = inputstream.ReadLine();
            }
            inputstream.Close();
        }
    }
}
