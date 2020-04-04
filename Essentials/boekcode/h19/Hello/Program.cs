using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Hi there " + name);
            string wait = Console.ReadLine();
        }
    }
}
