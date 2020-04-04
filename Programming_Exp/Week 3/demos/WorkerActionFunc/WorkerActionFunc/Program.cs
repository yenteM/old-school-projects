using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkerActionFunc
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            // using custom delegates
            var data = new ProcessData();
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;
            data.Process(2, 3, multiplyDel);

            // using Actions
            Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int > myMultiplyAction = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(2, 3, myAction);
            data.ProcessAction(2, 3, myMultiplyAction);

            // using Func
            Func<int, int, int> funcAddDel = (x, y) => x + y;
            Func<int, int, int> funcMultiplyDel = (x, y) => x * y;
            data.ProcessFunc(2, 3, funcAddDel);
            data.ProcessFunc(2, 3, funcMultiplyDel);
            
            var worker = new Worker();
            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine("Work performed: " + e.Hours);
            };


            worker.WorkCompleted += (s, e) =>
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
