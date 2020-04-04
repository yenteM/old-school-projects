using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureSensor;
using TemperatureSersorApp.Views;

namespace TemperatureSersorApp
{
    public sealed class Mediator
    {
        //Singleton functionality
        private static readonly Mediator _Instance = new Mediator();
        private Mediator() { }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        //Instance functionality
        public event EventHandler<TempEventArgs> JobChanged;

        public void OnJobChanged(Object sender, Double temp)
        {
            var jobChangeDelegate = JobChanged as EventHandler<TempEventArgs>;
            if (jobChangeDelegate != null)
            {
                jobChangeDelegate(sender, new TempEventArgs {Temp = temp});
            }
        }
    }
}
