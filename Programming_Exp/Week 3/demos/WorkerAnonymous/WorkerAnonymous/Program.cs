using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {

            var worker = new Worker();
            worker.WorkPerformed += delegate(object sender, WorkPerformedEventArgs e)
            {
                Console.WriteLine("Work performed: " + e.Hours);
            };


            worker.WorkCompleted += delegate(object sender, EventArgs e)
            {
                Console.WriteLine("Worker is done");
            };


            worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
