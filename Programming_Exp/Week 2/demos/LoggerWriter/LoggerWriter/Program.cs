using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerWriter
{
    class Program
    {
        public delegate void Writer(string message);

        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Writer writer = new Writer(logger.WriteMessage);
            writer("Success!!");
        }
    }
}
