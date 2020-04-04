using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TemperatureSensor;

namespace LightingApp.Collectors
{
    public delegate void MinTempSensorHandler(object sender, TempEventArgs e);

    public class MinimumTemperatureCollector
    {
        public event MinTempSensorHandler minTempSensor;
        private int count = 0;
        private double minValue = 41.0;

        public virtual void GetMinTemp(double temp)
        {
            OnGettingMinTemp(temp);
        }

        public virtual void OnGettingMinTemp(double temp)
        {
            MinTempSensorHandler min = minTempSensor as MinTempSensorHandler;
            if (temp < minValue)
            {
                minValue = temp;
            }

            if (count == 10)
            {
                min?.Invoke(this, new TempEventArgs(minValue));
            }

            count++;
        }
    }
}
