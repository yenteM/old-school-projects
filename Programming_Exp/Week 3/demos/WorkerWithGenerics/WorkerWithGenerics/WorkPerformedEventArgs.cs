using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerWithGenerics
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(int hours, WorkType wt)
        {
            Hours = hours;
            WorkType = wt;
        }

        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}
