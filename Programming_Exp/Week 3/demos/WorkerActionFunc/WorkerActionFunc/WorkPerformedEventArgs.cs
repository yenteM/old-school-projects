using System;

namespace WorkerActionFunc
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