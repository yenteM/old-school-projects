using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();

            worker.WorkPerformed += Worker_WorkPerformed; // inference
            worker.WorkCompleted += Worker_WorkCompleted; // inference
            worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }

        static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs args)
        {
            Console.WriteLine("Work performed: " + args.Hours);
        }

        static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
