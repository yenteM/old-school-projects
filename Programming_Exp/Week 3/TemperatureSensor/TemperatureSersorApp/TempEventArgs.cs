using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureSensor
{
    public class TempEventArgs : EventArgs
    {

        public double Temp { get; set; }
    }
}
