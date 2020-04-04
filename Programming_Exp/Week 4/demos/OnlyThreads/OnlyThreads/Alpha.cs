using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnlyThreads
{
    public class Alpha
    {
        // This method that will be called when the thread is started
        public void Beta()
        {
            while (true)
            {
                Console.WriteLine("Alpha.Beta is running in its own thread.");
                Thread.Sleep(500);
            }
        }
    };
}
