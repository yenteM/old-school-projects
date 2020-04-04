using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerDemo
{
    class Program
    {
        public delegate void WorkPerformedHandler(int hours,
                                                  WorkType workType);

        static void Main(string[] args)
        {
            var del1 = new WorkPerformedHandler(WorkPerformed1);
            var del2 = new WorkPerformedHandler(WorkPerformed2);

            del1 += del2;

            del1(5, WorkType.Golf);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("Workperformed1 called.");
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("Workperformed2 called.");
        }

        public enum WorkType
        {
            GoToMeetings,
            Golf,
            GenerateReports
        }
    }
}
